using System.ComponentModel.DataAnnotations;

namespace HospitalManager.IDP.Entities;

public class User : IConcurrencyAware
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(200)]
    [Required]
    public string Subject { get; set; }
    
    [MaxLength(254)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }

    [MaxLength(200)]
    public string Password { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [ConcurrencyCheck]
    public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

    public ICollection<UserClaim> Claims { get; set; } = new List<UserClaim>();
}