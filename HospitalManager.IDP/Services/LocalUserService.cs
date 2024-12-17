using HospitalManager.IDP.DbContexts;
using HospitalManager.IDP.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HospitalManager.IDP.Services;

public class LocalUserService : ILocalUserService
{
    private readonly IdentityDbContext _context;
    private readonly IPasswordHasher<User> _passwordHasher;

    public LocalUserService(IdentityDbContext context, IPasswordHasher<User> passwordHasher)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
    }

    public async Task<bool> IsUserActive(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            return false;
        }

        var user = await GetUserBySubjectAsync(subject);

        if (user == null)
        {
            return false;
        }

        return user.IsActive;
    }

    public async Task<bool> ValidateCredentialsAsync(string username,
      string password)
    {
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        var user = await GetUserByUsernameAsync(username);

        if (user == null)
        {
            return false;
        }

        if (!user.IsActive)
        {
            return false;
        }

        var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, password);
        return (verificationResult == PasswordVerificationResult.Success);
    }

    public async Task<IEnumerable<UserClaim>> GetUserClaimsBySubjectAsync(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            throw new ArgumentNullException(nameof(subject));
        }

        return await _context.UserClaims.Where(u => u.User.Subject == subject).ToListAsync();
    }

    public async Task<User?> GetUserByUsernameAsync(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException(nameof(email));
        }

        return await _context.Users
             .FirstOrDefaultAsync(u => u.Email == email);
    }
    
    public async Task<User?> GetUserBySubjectAsync(string subject)
    {
        if (string.IsNullOrWhiteSpace(subject))
        {
            throw new ArgumentNullException(nameof(subject));
        }

        return await _context.Users.FirstOrDefaultAsync(u => u.Subject == subject);
    }
    
    public void AddUser(User userToAdd, string password)
    {
        if (userToAdd == null)
        {
            throw new ArgumentNullException(nameof(userToAdd));
        }

        if (_context.Users.Any(u => u.Email == userToAdd.Email))
        {
            throw new Exception("Unable to create user with specified email");
        }
        
        userToAdd.Password = _passwordHasher.HashPassword(userToAdd, password);
        
        _context.Users.Add(userToAdd);
    }


    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() > 0);
    }
}