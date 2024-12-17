using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetById(int id);
        Task Add(Address address);
        Task Update(Address address);
        Task Delete(Address address);
        Task<Address> GetByDetails(string city, string street, int streetNumber, int postalCode, string region, string district);

        Task<IEnumerable<Address>> GetAll();
    }
}
