using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Patient")]
public class Patient : BaseEntity
{
    public Insurance? Insurance { get; set; }
    
    [Required]
    public Person Person { get; set; }
    
    [ForeignKey(nameof(Person))]
    public string BirthNumber { get; set; }
    
    [MaxLength(2000)]
    public string? Allergies { get; set; }
    
    [MaxLength(2000)]
    public string? BloodGroup { get; set; }
    
    [MaxLength(2000)]
    public string? Medications { get; set; }
    
    [MaxLength(2000)]
    public string? Vaccines { get; set; }
    
    [Required]
    public int DoctorId { get; set; }

    [ForeignKey(nameof(DoctorId))] 
    public Doctor? Doctor { get; set; }
}