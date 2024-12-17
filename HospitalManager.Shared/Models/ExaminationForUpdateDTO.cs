namespace HospitalManager.Shared.Models;

public class ExaminationForUpdateDTO
{
    public DateTime? ExaminationDate { get; set; }
    public string? Symptoms { get; set; }
    public string? Diagnosis { get; set; }
    public string? Treatment { get; set; }
    public string? Notes { get; set; }
}