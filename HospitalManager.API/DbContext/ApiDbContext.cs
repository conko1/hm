using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.DbContexts;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}
}