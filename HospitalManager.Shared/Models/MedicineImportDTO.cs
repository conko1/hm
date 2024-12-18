namespace HospitalManager.Shared.Models;

public class MedicineImportDTO
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Complement { get; set; }
    public string StateCode { get; set; }
    public string RegCode { get; set; }
    public int Expiration { get; set; }
    public string Recipe { get; set; }
    public DateOnly RegistrationDate { get; set; }
}