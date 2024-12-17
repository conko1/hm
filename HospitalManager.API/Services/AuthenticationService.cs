using System.Security.Claims;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Services;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationService(IHttpContextAccessor httpContextAccessor)
    {
        
    }
    
    public ClaimsPrincipal GetUser()
    {
        throw new NotImplementedException();
    }

    public string GetUserId()
    {
        throw new NotImplementedException();
    }

    public string GetUserName()
    {
        throw new NotImplementedException();
    }

    public string GetUserEmail()
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetDatabaseUserAsync()
    {
        throw new NotImplementedException();
    }
}