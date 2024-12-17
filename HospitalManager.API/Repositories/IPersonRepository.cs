using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetByBirthNumber(string birthNumber);
        Task<Person> GetByEmail(string email);
        Task<IEnumerable<Person>> GetAll();
        Task Add(Person person);
        Task Update(Person person);
        Task Delete(Person person);
    }
}
