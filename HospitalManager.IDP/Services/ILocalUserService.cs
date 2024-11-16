using HospitalManager.IDP.Entities;

namespace HospitalManager.IDP.Services;

public interface ILocalUserService
{
    Task<bool> ValidateCredentialsAsync(
        string username,
        string password);

    Task<IEnumerable<UserClaim>> GetUserClaimsBySubjectAsync(
        string subject);

    Task<User?> GetUserByUsernameAsync(
        string username);

    Task<User?> GetUserBySubjectAsync(
        string subject);

    void AddUser
        (User userToAdd, string password);

    Task<bool> IsUserActive(
        string subject);

    Task<bool> SaveChangesAsync();
}