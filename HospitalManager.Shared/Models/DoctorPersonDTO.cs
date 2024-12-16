namespace HospitalManager.Shared.Models;

public class DoctorPersonDTO
{
    public int Id { get; set; }
    public string BirthNumber { get; set; }
    public string Specialization { get; set; }
    public int DepartmentId { get; set; }
}