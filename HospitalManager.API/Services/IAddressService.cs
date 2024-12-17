using HospitalManager.Shared.Models;

namespace HospitalManager.API.Services
{
    public interface IAddressService
    {
        Task<AddressDTO> GetById(int id);
        Task<IEnumerable<AddressDTO>> GetAll();
        Task Add(AddressDTO addressDTO);
        Task<AddressDTO> Update(int id, AddressDTO addressDTO);
        Task Delete(int id);
    }
}
