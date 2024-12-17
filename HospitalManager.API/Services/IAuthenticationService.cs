using System.Security.Claims;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Services;

public interface IAuthenticationService
{
    ClaimsPrincipal GetUser();
    string GetUserId();
    string GetUserName();
    string GetUserEmail();
    Task<User> GetDatabaseUserAsync();
}