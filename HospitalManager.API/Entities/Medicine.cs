using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("Medicine")]
public class Medicine : BaseEntity
{
    [Required]
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? Dosage { get; set; }
    
    public string? Quantity { get; set; }
    
    public string? SideEffects { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    
    public IEnumerable<Recipe> Recipes { get; set; } = new List<Recipe>();
}