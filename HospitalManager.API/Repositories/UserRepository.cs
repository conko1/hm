using HospitalManager.API.DbContexts;
using HospitalManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApiDbContext _context;

    public UserRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    public async Task<User> GetUserById(int id)
    {
        var user = await _context.Users
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        return user;
    }

    public async Task CreateUser(User user)
    {
        await _context.Users.AddAsync(user);
    }
    
    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}