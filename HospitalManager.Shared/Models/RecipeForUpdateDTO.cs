namespace HospitalManager.Shared.Models;

public class RecipeForUpdateDTO
{
    public IList<int>? Medicines { get; set; }
    public DateTime? Expiration { get; set; }
    public bool? Used { get; set; } = false;
}