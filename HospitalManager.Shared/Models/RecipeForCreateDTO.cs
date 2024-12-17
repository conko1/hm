namespace HospitalManager.Shared.Models;

public class RecipeForCreateDTO
{
    public IList<int>? Medicines { get; set; }
    public int ExaminationId { get; set; }
    public DateTime Expiration { get; set; }
    public bool Used { get; set; } = false;
}