using HospitalManager.API.Entities;

namespace HospitalManager.API.Dtos
{
    public class PersonDTO
    {
        public string BirthNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public int AddressId { get; set; }

        public int UserId { get; set; }
    }
}
