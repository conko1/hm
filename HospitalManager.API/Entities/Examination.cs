using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Examination")]
public class Examination : BaseEntity
{
    [Required]
    public Doctor Doctor { get; set; }
    
    [Required]
    public Patient Patient { get; set; }
    
    public Recipe? Recipe { get; set; }
    
    [Required]
    public DateTime ExaminationDate { get; set; }
    
    [MaxLength(2000)]
    public string? Symptoms { get; set; }
    
    [MaxLength(2000)]
    public string? Diagnosis { get; set; }
    
    [MaxLength(2000)]
    public string? Treatment { get; set; }
    
    [MaxLength(2000)]
    public string? Notes { get; set; }
}