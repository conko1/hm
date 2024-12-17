using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using System;

namespace HospitalManager.API.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IMapper mapper, IInsuranceRepository insuranceRepository, IPersonRepository personRepository, IAddressRepository addressRepository, IDoctorRepository doctorRepository)
        { 
            this._patientRepository = patientRepository;
            this._mapper = mapper;
            this._insuranceRepository = insuranceRepository;
            this._personRepository = personRepository;
            this._addressRepository = addressRepository;
            this._doctorRepository = doctorRepository;
        }
        public async Task Add(RegisterPatientDTO registerPatientDTO)
        {
            var patient = await this._patientRepository.GetByBirthNumber(registerPatientDTO.BirthNumber);
            if (patient != null)
            {
                throw new ArgumentException($"Patient with birth number {registerPatientDTO.BirthNumber} already exists.");
            }
            else
            {
                var person = await this._personRepository.GetByBirthNumber(registerPatientDTO.BirthNumber);
                if (person == null)
                {
                    person = new Person
                    {
                        BirthNumber = registerPatientDTO.BirthNumber,
                        FirstName = registerPatientDTO.FirstName,
                        LastName = registerPatientDTO.LastName,
                        Telephone = registerPatientDTO.Telephone,
                        Email = registerPatientDTO.Email,
                    };
                    await this._personRepository.Add(person);
                }

                Patient newPatient = new Patient
                {
                    Person = person,
                    BirthNumber = registerPatientDTO.BirthNumber,
                    DoctorId = 1
                };
                await this._patientRepository.Add(newPatient);
            }

        }

        public async Task Delete(int id)
        {
            var patient = await this._patientRepository.GetById(id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");
            }
            await _patientRepository.Delete(patient);
        }

        public async Task<IEnumerable<PatientDTO>> GetAll(bool expandPerson)
        {
            var patients = await this._patientRepository.GetAll();
            if (patients == null || !patients.Any()) 
            {
                throw new InvalidOperationException("No record of Patients found.");         
            }

            if (expandPerson)
            {
                patients = await this._patientRepository.GetAllWithPerson();
            }
            var patientsDTO = _mapper.Map<IEnumerable<PatientDTO>>(patients);
            return patientsDTO;
        }

        public async Task<PatientDTO> GetById(int id, bool expandPerson)
        {
            if (!await this._patientRepository.PatientExists(id))
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");

            }
            Patient? patient = null;
            if (expandPerson)
            {
                patient = await this._patientRepository.GetPatientWithPerson(id);
            }
            else {
                patient = await this._patientRepository.GetById(id);
            }

            var patientDTO = _mapper.Map<PatientDTO>(patient);
            return patientDTO;
        }

        public async Task<PatientDTO> Update(int id, PatientForUpdateDTO patientDto)
        {
            var patient = await this._patientRepository.GetPatientWithPerson(id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");
            }

            var person = patient.Person;
            person.FirstName = patientDto.FirstName;
            person.LastName = patientDto.LastName;
            person.Email = patientDto.Email;
            person.Telephone = patientDto.Telephone;

            patient.Insurance = await this._insuranceRepository.GetById(patientDto.InsuranceId);
            patient.Allergies = patientDto.Allergies;
            patient.BloodGroup = patientDto.BloodGroup;
            patient.Medications = patientDto.Medications;
            patient.Vaccines = patientDto.Vaccines;

            await this._personRepository.Update(person);
            await this._patientRepository.Update(patient);

            var patientDTO = _mapper.Map<PatientDTO>(patient);
            return patientDTO;
        }
    }
}
