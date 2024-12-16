using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Insurance")]
public class Insurance
{
    [Key]
    [Range(10, 99)]
    public int Code { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string Abbreviation { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FullName { get; set; }
}