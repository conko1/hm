namespace HospitalManager.Shared.Models;

public class RecipeDTO
{
    public int Id { get; set; }
    public IEnumerable<int> Medicines { get; set; } = new List<int>();
    public DateTime Expiration { get; set; }
    public int ExaminationId { get; set; }
    public bool Used { get; set; } = false;
}