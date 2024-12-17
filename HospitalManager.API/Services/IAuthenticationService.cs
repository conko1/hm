using System.Security.Claims;
using HospitalManager.API.Entities;

namespace HospitalManager.API.Services;

public interface IAuthenticationService
{
    ClaimsPrincipal? GetUser();
    Task CheckIfUserSubRegistered();
    (String Email, String Role, String Subject) GetUserClaims();
    Task<User?> GetDatabaseUser();
}