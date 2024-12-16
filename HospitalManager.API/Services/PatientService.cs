using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;

namespace HospitalManager.API.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IMapper mapper, IInsuranceRepository insuranceRepository, IPersonRepository personRepository, IAddressRepository addressRepository)
        { 
            this._patientRepository = patientRepository;
            this._mapper = mapper;
            this._insuranceRepository = insuranceRepository;
            this._personRepository = personRepository;
            this._addressRepository = addressRepository;
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
                var existingAddress = await this._addressRepository.GetByDetails(registerPatientDTO.City, registerPatientDTO.Street, registerPatientDTO.StreetNumber, registerPatientDTO.PostalCode);
                Address newAddress;

                if (existingAddress != null)
                {
                    newAddress = existingAddress;
                }
                else
                {
                    newAddress = new Address
                    {
                        City = registerPatientDTO.City,
                        Street = registerPatientDTO.Street,
                        StreetNumber = registerPatientDTO.StreetNumber,
                        PostalCode = registerPatientDTO.PostalCode,
                        Region = registerPatientDTO.Region,
                        District = registerPatientDTO.District,
                    };
                    await this._addressRepository.Add(newAddress);
                }

                var person = await this._personRepository.GetById(registerPatientDTO.BirthNumber);
                if (person == null)
                {
                    person = new Person
                    {
                        BirthNumber = registerPatientDTO.BirthNumber,
                        FirstName = registerPatientDTO.FirstName,
                        LastName = registerPatientDTO.LastName,
                        Telephone = registerPatientDTO.Telephone,
                        Email = registerPatientDTO.Email,
                        Address = newAddress
                    };
                    await this._personRepository.Add(person);
                }

                Patient newPatient = new Patient
                {
                    Person = person,
                    insurance = await _insuranceRepository.GetById(registerPatientDTO.InsuranceId),
                    Allergies = registerPatientDTO.Allergies,
                    BloodGroup = registerPatientDTO.BloodGroup,
                    Medications = registerPatientDTO.Medications,
                    Vaccines = registerPatientDTO.Vaccines
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

        public async Task<IEnumerable<PatientDTO>> GetAll()
        {
            var patients = await this._patientRepository.GetAll();
            if (patients == null || !patients.Any()) 
            {
                throw new InvalidOperationException("No record of Patients found.");         
            }
            var patientsDTOs = _mapper.Map<IEnumerable<PatientDTO>>(patients);
            return patientsDTOs;
        }

        public async Task<PatientDTO> GetById(int id)
        {
            var patient = await this._patientRepository.GetById(id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");

            }
            var patientDTO = _mapper.Map<PatientDTO>(patient);
            return patientDTO;
        }

        public async Task Update(PatientDTO patientDto)
        {
            var patient = await this._patientRepository.GetById(patientDto.Id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {patientDto.Id} not found.");
            }
            patient.insurance = await this._insuranceRepository.GetById(patientDto.InsuranceId);
            patient.Allergies = patientDto.Allergies;
            patient.BloodGroup = patientDto.BloodGroup;
            patient.Medications = patientDto.Medications;
            patient.Vaccines = patientDto.Vaccines;

            await this._patientRepository.Update(patient);
        }
    }
}
