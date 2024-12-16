using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly ApiDbContext context;

        public InsuranceRepository(ApiDbContext context)
        {
            this.context = context;
        }

        public async Task Add(Insurance insurance)
        {
            await this.context.Insurances.AddAsync(insurance);
            await this.context.SaveChangesAsync();
        }

        public async Task Delete(Insurance insurance)
        {
            this.context.Insurances.Remove(insurance);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Insurance>> GetAll()
        {
            return await this.context.Insurances.ToListAsync();
        }

        public async Task<Insurance> GetById(int id)
        {
            return await this.context.Insurances.FindAsync(id);
        }

        public async Task Update(Insurance insurance)
        {
            this.context.Insurances.Update(insurance);
            await this.context.SaveChangesAsync();
        }
    }
}
