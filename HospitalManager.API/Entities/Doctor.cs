using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Doctor")]
public class Doctor : BaseEntity
{
    [Required]
    public Person Person { get; set; }
    
    [ForeignKey(nameof(Person))]
    public string BirthNumber { get; set; }
    
    [MaxLength(50)]
    public string? Specialization { get; set; }
    
    public IEnumerable<Patient> Patients { get; set; } = new List<Patient>();
}