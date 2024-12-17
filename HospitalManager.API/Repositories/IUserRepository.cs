using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUserById(int id);
    Task<User> GetUserBySubId(string id);
    Task CreateUser(User user);
    Task SaveChanges();
}