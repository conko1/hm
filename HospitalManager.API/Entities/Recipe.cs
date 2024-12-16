using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Recipe")]
public class Recipe : BaseEntity
{
    public IEnumerable<Medicine> Medicines { get; set; } = new List<Medicine>();
    
    [Required]
    public Doctor Doctor { get; set; }  
    
    [Required]
    public Patient Patient { get; set; }
    
    [Required]
    public DateTime Expiration { get; set; }
    
    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool Used { get; set; } = false;
}