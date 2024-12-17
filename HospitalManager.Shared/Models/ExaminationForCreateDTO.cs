using System.ComponentModel.DataAnnotations;

namespace HospitalManager.Shared.Models;

public class ExaminationForCreateDTO
{
    [Required] 
    public int? PatientId { get; set; } = null;
    [Required] 
    public DateTime? ExaminationDate { get; set; } = null;
    public string? Symptoms { get; set; }
    public string? Diagnosis { get; set; }
    public string? Treatment { get; set; }
    public string? Notes { get; set; }
}