using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Invitation")]
public class Invitation  : BaseEntity
{
    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool Used { get; set; } = false;
    
    [Required]
    [MaxLength(2048)]
    public string JwtToken { get; set; }
}