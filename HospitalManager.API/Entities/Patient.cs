using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Patient")]
public class Patient : BaseEntity
{
    public Insurance insurance { get; set; }
    
    [Required]
    public User User { get; set; }
    
    [Required]
    public Person Person { get; set; }
    
    [MaxLength(2000)]
    public string Allergies { get; set; }
    
    [MaxLength(2000)]
    public string BloodGroup { get; set; }
    
    [MaxLength(2000)]
    public string Medications { get; set; }
    
    [MaxLength(2000)]
    public string Vaccines { get; set; }
    
}