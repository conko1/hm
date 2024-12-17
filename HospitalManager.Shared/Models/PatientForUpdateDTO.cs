using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Shared.Models
{
    public class PatientForUpdateDTO
    {
        public int InsuranceId { get; set; }
        public string BirthNumber { get; set; }
        public string Allergies { get; set; }
        public string BloodGroup { get; set; }
        public string Medications { get; set; }
        public string Vaccines { get; set; }
    }
}
