namespace HospitalManager.API.Dtos;

public class MedicineDTO
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string Dosage { get; set; }
    
    public string Quantity { get; set; }
    
    public string SideEffects { get; set; }
    
    public decimal Price { get; set; }
}