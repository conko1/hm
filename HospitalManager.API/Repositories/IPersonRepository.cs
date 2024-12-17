using HospitalManager.API.Entities;

namespace HospitalManager.API.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetById(string birthNumber);
        Task<IEnumerable<Person>> GetAll();
        Task Add(Person person);
        Task Update(Person person);
        Task Delete(Person person);
    }
}
