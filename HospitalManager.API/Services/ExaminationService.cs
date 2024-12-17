using System.Diagnostics;
using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HospitalManager.API.Services;

public class ExaminationService : IExaminationService
{
    private readonly IExaminationRepository _examinationRepository;
    private readonly IPatientRepository _patientRepository;
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;

    public ExaminationService(
        IExaminationRepository examinationRepository,
        IPatientRepository patientRepository,
        IDoctorRepository doctorRepository,
        IMapper mapper)
    {
        _examinationRepository = examinationRepository;
        _patientRepository = patientRepository;
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    
    public async Task<ServiceResponse<IEnumerable<ExaminationDTO>>> GetExaminations()
    {
        var examinations = await _examinationRepository.GetAllExaminations();
        var examinationsDto = _mapper.Map<IEnumerable<ExaminationDTO>>(examinations);
        return ServiceResponse<IEnumerable<ExaminationDTO>>.Success(examinationsDto);
    }

    public async Task<ServiceResponse<ExaminationDTO>> GetExamination(int id)
    {
        var examination = await _examinationRepository.GetExaminationById(id);
        if (examination == null)
        {
            return ServiceResponse<ExaminationDTO>.Failure("Examination not found", 404);
        }
        
        var examinationDto = _mapper.Map<ExaminationDTO>(examination);
        
        return ServiceResponse<ExaminationDTO>.Success(examinationDto);
    }

    public async Task<ServiceResponse<ExaminationDTO>> UpdateExamination(int id,
        JsonPatchDocument<ExaminationForUpdateDTO> patchDocument)
    {
        var examinationEntity = await _examinationRepository.GetExaminationById(id);
        if (examinationEntity == null)
        {
            return ServiceResponse<ExaminationDTO>.Failure("Examination not found", 404);
        }
        
        var examinationToUpdate = _mapper.Map<ExaminationForUpdateDTO>(examinationEntity);

        var modelState = new ModelStateDictionary();
        
        patchDocument.ApplyTo(examinationToUpdate, modelState);

        if (!modelState.IsValid)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return ServiceResponse<ExaminationDTO>.Failure(errors, 400);
        }
        
        _mapper.Map(examinationToUpdate, examinationEntity);
        await _examinationRepository.SaveChanges();
        
        return ServiceResponse<ExaminationDTO>.Success(_mapper.Map<ExaminationDTO>(examinationEntity));
    }

    public async Task<ServiceResponse<ExaminationDTO>> AddExamination(ExaminationForCreateDTO createExamination)
    {
        var examinationEntity = _mapper.Map<Examination>(createExamination);

        Patient? patient = new Patient();
        if (createExamination.PatientId != null)
        {
            patient = await _patientRepository.GetById(createExamination.PatientId);
            if (patient == null)
            {
                return ServiceResponse<ExaminationDTO>.Failure("Patient not found", 400);
            }
        }

        Doctor doctor = await _doctorRepository.GetDoctorById(1);
        examinationEntity.Doctor = doctor;
        examinationEntity.Patient = patient;
        
        await _examinationRepository.AddExamination(examinationEntity);
        await _examinationRepository.SaveChanges();
        
        var examinationDto = _mapper.Map<ExaminationDTO>(examinationEntity);
        return ServiceResponse<ExaminationDTO>.Success(examinationDto);
    }

    public async Task<ServiceResponse> DeleteExamination(int id)
    {
        var examination = await _examinationRepository.GetExaminationById(id);
        if (examination == null)
        {
            return ServiceResponse.Failure("Examination not found", 404);
        }

        await _examinationRepository.DeleteExamination(examination);
        await _examinationRepository.SaveChanges();
        return ServiceResponse.Success();
    }
}