using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Shared.Models
{
    public class InsuranceDTO
    {
        public int Code { get; set; }
        public string Abbreviation { get; set; }
        public string FullName { get; set; }
    }
}
