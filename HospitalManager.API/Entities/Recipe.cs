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
    
    [ForeignKey(nameof(Examination))]
    public int ExaminationId { get; set; }
    
    [Required]
    [Range(0, 1)]
    public int Used { get; set; }
}