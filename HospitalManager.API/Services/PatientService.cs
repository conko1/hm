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
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository patientRepository, IMapper mapper, IInsuranceRepository insuranceRepository)
        { 
            this._patientRepository = patientRepository;
            this._mapper = mapper;
            this._insuranceRepository = insuranceRepository;
        }
        public async Task Add(PatientDTO patientDto)
        {
            var patient = await this._patientRepository.GetById(patientDto.Id);
            if (patient != null)
            {
                throw new ArgumentException($"Patient with ID {patientDto.Id} already exists.");
            }
            else {
                Patient newPatient = new Patient();
                newPatient.Insurance = await this._insuranceRepository.GetById(patientDto.InsuranceId);
                newPatient.Allergies = patientDto.Allergies;
                newPatient.BloodGroup = patientDto.BloodGroup;
                newPatient.Medications = patientDto.Medications;
                newPatient.Vaccines = patientDto.Vaccines;

                this._patientRepository.Add(newPatient);
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
            patient.Insurance = await this._insuranceRepository.GetById(patientDto.InsuranceId);
            patient.Allergies = patientDto.Allergies;
            patient.BloodGroup = patientDto.BloodGroup;
            patient.Medications = patientDto.Medications;
            patient.Vaccines = patientDto.Vaccines;

            await this._patientRepository.Update(patient);
        }
    }
}
