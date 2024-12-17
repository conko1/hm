using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Shared.Models
{
    public class AddressDTO
    {
        public string City { get; set; }

        public string Region { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public int PostalCode { get; set; }
        
    }
}
