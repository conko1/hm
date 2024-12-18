using AutoMapper;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using HospitalManager.Shared.Service;

namespace HospitalManager.API.Services
{
    public class InsuranceService : IInsuranceService
    {
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IMapper _mapper;

        public InsuranceService(IInsuranceRepository insuranceRepository, IMapper mapper)
        {
            _insuranceRepository = insuranceRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InsuranceDTO>> GetAll()
        {
            var insurances = await this._insuranceRepository.GetAll();
            if (insurances == null || !insurances.Any())
            {
                throw new InvalidOperationException("No records of Insurances found.");
            }
            var insurancesDTO = _mapper.Map<IEnumerable<InsuranceDTO>>(insurances);
            return insurancesDTO;
        }

        public async Task<InsuranceDTO> GetById(int id)
        {
            var insurance = await this._insuranceRepository.GetById(id);
            if (insurance == null)
            {
                throw new KeyNotFoundException($"Insurances with ID {id} not found.");

            }
            var insuranceDTO = _mapper.Map<InsuranceDTO>(insurance);
            return insuranceDTO;
        }
    }
}
