using AutoMapper;
using HospitalManager.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HospitalManager.API.Services;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;

    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    
    public async Task<ServiceResponse<IEnumerable<DoctorDTO>>> GetDoctors()
    {
        var doctors = await _doctorRepository.GetAllDoctors();
        var doctorsDto = _mapper.Map<IEnumerable<DoctorDTO>>(doctors);
        return ServiceResponse<IEnumerable<DoctorDTO>>.Success(doctorsDto);
    }

    public async Task<ServiceResponse<DoctorDTO>> GetDoctor(int id)
    {
        var doctor = await _doctorRepository.GetDoctorById(id);
        if (doctor == null)
        {
            return ServiceResponse<DoctorDTO>.Failure("Doctor not found", 404);
        }
;
        var doctorDto = _mapper.Map<DoctorDTO>(doctor);
        
        return ServiceResponse<DoctorDTO>.Success(doctorDto);
    }

    public async Task<ServiceResponse<DoctorDTO>> UpdateDoctor(int doctorId, JsonPatchDocument<DoctorForUpdateDTO> patchDoctor)
    {
        var doctorEntity = await _doctorRepository.GetDoctorById(doctorId);
        if (doctorEntity == null)
        {
            return ServiceResponse<DoctorDTO>.Failure("Doctor not found", 404);
        }
        
        var doctorToUpdate = _mapper.Map<DoctorForUpdateDTO>(doctorEntity);
        
        var modelState = new ModelStateDictionary();

        patchDoctor.ApplyTo(doctorToUpdate, modelState);

        if (!modelState.IsValid)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return ServiceResponse<DoctorDTO>.Failure(errors, 400);
        }
        
        _mapper.Map(doctorToUpdate, doctorEntity);
        await _doctorRepository.SaveChanges();
        
        return ServiceResponse<DoctorDTO>.Success(_mapper.Map<DoctorDTO>(doctorEntity));
    }

    public async Task<ServiceResponse> DeleteDoctor(int id)
    {
        var doctorEntity = await _doctorRepository.GetDoctorById(id);
        if (doctorEntity == null)
        {
            return ServiceResponse.Failure("Doctor not found", 404);
        }
        
        await _doctorRepository.DeleteDoctor(id);
        return ServiceResponse.Success();
    }
}