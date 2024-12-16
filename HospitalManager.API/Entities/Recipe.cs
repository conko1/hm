using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Recipe")]
public class Recipe : BaseEntity
{
    public IEnumerable<Medicine> Medicines { get; set; } = new List<Medicine>();
    
    [Required]
    public DateTime Expiration { get; set; }
    
    [Required]
    public Examination Examination { get; set; }
    
    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool Used { get; set; } = false;
}