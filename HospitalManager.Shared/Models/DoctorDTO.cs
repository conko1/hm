using System.Text.Json.Serialization;

namespace HospitalManager.Shared.Models;

public class DoctorDTO
{
    public int Id { get; set; }
    public string BirthNumber { get; set; }
    public string Specialization { get; set; }
    public int DepartmentId { get; set; }
    public PersonDTO? Person { get; set; }
}