using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApiDbContext _context;

        public AddressRepository(ApiDbContext context)
        { 
            this._context = context;
        }

        public async Task Add(Address address)
        {
            await this._context.Addresses.AddAsync(address);
            await this._context.SaveChangesAsync();
        }

        public async Task Delete(Address address)
        {
            this._context.Addresses.Remove(address);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            return await this._context.Addresses.ToListAsync();
        }

        public async Task<Address> GetByDetails(string city, string street, int streetNumber, int postalCode, string region, string district)
        {
            return await _context.Addresses.FirstOrDefaultAsync(a => a.City == city && a.Street == street && a.StreetNumber == streetNumber && a.PostalCode == postalCode && a.Region == region && a.District == district);
        }

        public async Task<Address> GetById(int id)
        {
            return await this._context.Addresses.FindAsync(id);
        }

        public async Task Update(Address address)
        {
            this._context.Addresses.Update(address);
            await this._context.SaveChangesAsync();
        }
    }
}
