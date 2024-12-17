using AutoMapper;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;
using HospitalManager.Shared.Models;
using System.Net;

namespace HospitalManager.API.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        { 
            this._addressRepository = addressRepository;
            this._mapper = mapper;
        }
        public async Task Add(AddressDTO addressDTO)
        {
            var adddress = await this._addressRepository.GetByDetails(addressDTO.City, addressDTO.Street, addressDTO.StreetNumber, addressDTO.PostalCode, addressDTO.Region, addressDTO.District);
            if (adddress != null)
            {
                throw new ArgumentException($"Address already exists.");
            }
            adddress = _mapper.Map<Address>(addressDTO);
            await this._addressRepository.Add(adddress);
        }

        public async Task Delete(int id)
        {
            var address = await this._addressRepository.GetById(id);
            if (address == null)
            {
                throw new KeyNotFoundException($"Address with ID {id} not found.");
            }
            await this._addressRepository.Delete(address);
        }

        public async Task<IEnumerable<AddressDTO>> GetAll()
        {
            var addresses = await this._addressRepository.GetAll();
            if (addresses == null || !addresses.Any())
            {
                throw new InvalidOperationException("No record of Addresses found.");
            }
            var addressesDTO = _mapper.Map<IEnumerable<AddressDTO>>(addresses);
            return addressesDTO;
        }

        public async Task<AddressDTO> GetById(int id)
        {
            var address = await this._addressRepository.GetById(id);
            if (address == null)
            {
                throw new KeyNotFoundException($"Address with ID {id} not found.");

            }
            var addressDTO = _mapper.Map<AddressDTO>(address);
            return addressDTO;
        }

        public async Task<AddressDTO> Update(int id, AddressDTO addressDTO)
        {
            var address = await this._addressRepository.GetById(id);
            if (address == null)
            {
                throw new KeyNotFoundException($"Address with ID {id} not found.");
            }
            this._mapper.Map(addressDTO, address);
            await this._addressRepository.Update(address);
            return _mapper.Map<AddressDTO>(address);
        }
    }
}
