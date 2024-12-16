using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("User")]
public class User : BaseEntity
{
    [RegularExpression(@"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$", 
        ErrorMessage = "SubjectId must be in specified format 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'.")]
    public string SubjectId { get; set; }
    
    [MaxLength(254)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }
}