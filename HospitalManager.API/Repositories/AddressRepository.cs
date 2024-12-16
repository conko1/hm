using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IAddressRepository _addressRepository;

        public AddressRepository(IAddressRepository addressRepository)
        { 
            this._addressRepository = addressRepository;
        }

        public Task Add(Address address)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
