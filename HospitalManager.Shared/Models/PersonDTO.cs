namespace HospitalManager.Shared.Models
{
    public class PersonDTO
    {
        public string BirthNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public AddressDTO? Address { get; set; }

        public int UserId { get; set; }
    }
}
