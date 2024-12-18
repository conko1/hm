namespace HospitalManager.Shared.Models;

public class MedicineImportPaginatedDTO
{
    public int TotalCount { get; set; }
    public int PageSize  { get; set; }
    public int CurrentPage  { get; set; }
    public int TotalPages  { get; set; }
    public bool HasPreviousPage  { get; set; }
    public bool HasNextPage  { get; set; }
    public IEnumerable<MedicineImportDTO> Results { get; set; }
}