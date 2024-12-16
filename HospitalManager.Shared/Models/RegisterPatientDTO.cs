using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Shared.Models
{
    public class RegisterPatientDTO
    {
        public string BirthNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int InsuranceId { get; set; }
        public string Allergies { get; set; }
        public string BloodGroup { get; set; }
        public string Medications { get; set; }
        public string Vaccines { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int PostalCode { get; set; }
    }
}
