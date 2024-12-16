using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly ApiDbContext _context;

        public InsuranceRepository(ApiDbContext context)
        {
            this._context = context;
        }

        public async Task Add(Insurance insurance)
        {
            await this._context.Insurances.AddAsync(insurance);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Insurance>> GetAll()
        {
            return await this._context.Insurances.ToListAsync();
        }

        public async Task<Insurance> GetById(int id)
        {
            return await this._context.Insurances.FindAsync(id);
        }
    }
}
