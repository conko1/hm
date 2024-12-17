using System.Security.Claims;
using HospitalManager.API.Entities;
using HospitalManager.API.Repositories;

namespace HospitalManager.API.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserRepository _userRepository;
    private readonly IPersonRepository _personRepository;
    private readonly string _email;
    private readonly string _sub;
    private readonly string _role;
    public AuthenticationService(
        IHttpContextAccessor httpContextAccessor,
        IUserRepository userRepository,
        IPersonRepository personRepository
        )
    {
        _httpContextAccessor = httpContextAccessor;
        _userRepository = userRepository;
        _personRepository = personRepository;

        (_sub, _email, _role) = GetSubEmailRoleClaim();
    }

    public ClaimsPrincipal? GetUser()
    {
        return _httpContextAccessor.HttpContext?.User;
    }

    public async Task CheckIfUserSubRegistered()
    {
        var person = await _personRepository.GetByEmail(_email);
        if (person == null)
        {
            throw new Exception("Unknown email address");
        }
        
        var user = await _userRepository.GetUserByEmail(_email);
        if (user == null)
        {
            user = new User()
            {
                Email = _email,
                SubjectId = _sub
            };

            await _userRepository.AddUser(user);
        }
        else
        {
            user.SubjectId = _sub;
        }
        
        await _userRepository.SaveChanges();
        
        person.User = user;
        await _personRepository.SaveChanges();
    }

    public (String Email, String Role, String Subject) GetUserClaims()
    {
        return (_email, _role, _sub);
    }

    public async Task<User?> GetDatabaseUser()
    {
        return await _userRepository.GetUserBySubId(_sub);
    }

    private (string Subject, string Email, string Role) GetSubEmailRoleClaim()
    {
        string email = "";
        string subject = "";
        string role = "";
        
        foreach (var claim in _httpContextAccessor.HttpContext.User.Claims)
        {
            if (claim.Type == "sub")
            {
                subject = claim.Value;
            }

            if (claim.Type == "Email")
            {
                email = claim.Value;
            }
            
            if (claim.Type == "Role")
            {
                role = claim.Value;
            }
        }
        
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(role))
        {
            throw new Exception("Either 'Email', 'sub' or 'Role' claim is missing");
        }
        
        return (subject, email, role);
    }
}