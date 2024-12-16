using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Address")]
public class Address : BaseEntity
{
    [MaxLength(50)]
    public string City { get; set; }
    
    [MaxLength(50)]
    public string Region { get; set; }
    
    [MaxLength(50)]
    public string District { get; set; }
    
    [MaxLength(50)]
    public string Street { get; set; }
    
    [Range(1, 99999)]
    public int StreetNumber { get; set; }
    
    [Range(1, 99999)]
    public int PostalCode { get; set; }
}