using HospitalManager.API.Dtos;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;

namespace HospitalManager.API.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository patientRepository;

        public PatientService(IPatientRepository patientRepository)
        { 
            this.patientRepository = patientRepository;
        }
        public Task Add(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            var patient = await this.patientRepository.GetById(id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");
            }
            await patientRepository.Delete(patient);
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            var patients = await this.patientRepository.GetAll();
            if (patients == null || !patients.Any()) 
            {
                throw new InvalidOperationException("No record of Patients found.");         
            }
            return patients;
        }

        public async Task<Patient> GetById(int id)
        {
            var patient = await this.patientRepository.GetById(id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {id} not found.");

            }
            return patient;
        }

        public async Task Update(PatientDto patientDto)
        {
            var patient = await this.patientRepository.GetById(patientDto.Id);
            if (patient == null)
            {
                throw new KeyNotFoundException($"Patient with ID {patientDto.Id} not found.");
            }
            patient.Allergies = patientDto.Allergies;
            patient.BloodGroup = patientDto.BloodGroup;
            patient.Medications = patientDto.Medications;
            patient.Vaccines = patientDto.Vaccines;

            await this.patientRepository.Update(patient);
        }
    }
}
