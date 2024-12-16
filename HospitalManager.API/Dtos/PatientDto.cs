using HospitalManager.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HospitalManager.API.Dtos
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public string BirthNumber { get; set; }
        public string Allergies { get; set; }
        public string BloodGroup { get; set; }
        public string Medications { get; set; }
        public string Vaccines { get; set; }
    }
}
