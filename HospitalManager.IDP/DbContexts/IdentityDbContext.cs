using Microsoft.EntityFrameworkCore;

namespace HospitalManager.IDP.DbContexts
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options): base(options){}
    }
}
