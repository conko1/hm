using System.ComponentModel.DataAnnotations;

namespace HospitalManager.Shared.Models;

public class RecipeForCreateDTO
{
    public IEnumerable<int>? Medicines { get; set; }
    [Required] 
    public int? ExaminationId { get; set; } = null;
    [Required]
    public DateTime? Expiration { get; set; } = null;
    public bool? Used { get; set; } = false;
}