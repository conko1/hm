using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Person")]
public class Person
{
    [Key]
    [RegularExpression(@"^\d{6}/\d{4}$", ErrorMessage = "BirthNumber must be in specified format '012345/1234'.")]
    public string BirthNumber { get; set; }
    
    [MaxLength(50)]
    public string? FirstName { get; set; }
    
    [MaxLength(50)]
    public string? LastName { get; set; }
    
    [MaxLength(254)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string? Email { get; set; }
    
    [RegularExpression(@"^\+421[0-9]{9}$", ErrorMessage = "Telephone must be in specified format '+421910595144'.")]
    public string? Telephone { get; set; }
    
    public Address? Address { get; set; }
    
    public User? User { get; set; }
}