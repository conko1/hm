using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Shared.Models
{
    public class PatientForUpdateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int InsuranceId { get; set; }
        public string BirthNumber { get; set; }
        public string? Allergies { get; set; }
        public string? BloodGroup { get; set; }
        public string? Medications { get; set; }
        public string? Vaccines { get; set; }
    }
}
