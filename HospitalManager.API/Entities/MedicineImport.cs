using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManager.API.Entities;

[Table("liek")]
public class MedicineImport
{
    [Key]
    [Column("sukl_kod")]
    public string Code { get; set; }
    [Column("nazov")]
    public string Name { get; set; }
    [Column("doplnok")]
    public string Complement { get; set; }
    [Column("kod_statu")]
    public string StateCode { get; set; }
    [Column("reg_cislo")]
    public string RegCode { get; set; }
    [Column("exspiracia")]
    public int Expiration { get; set; }
    [Column("vydaj")]
    public string Recipe { get; set; }
    [Column("dat_reg")]
    public DateOnly RegistrationDate { get; set; }
}