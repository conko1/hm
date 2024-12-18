using System.Security.Claims;
using HospitalManager.API.Entities;
using HospitalManager.Shared.Utils;

namespace HospitalManager.API.Services;

public interface IAuthenticationService
{
    ClaimsPrincipal? GetUser();
    Task CheckIfUserSubRegistered();
    (String Email, Roles Role, String Subject) GetUserClaims();
    Task<User?> GetDatabaseUser();
}