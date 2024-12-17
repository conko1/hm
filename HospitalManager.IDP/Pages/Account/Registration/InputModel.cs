using System.ComponentModel.DataAnnotations;

namespace HospitalManager.IDP.Pages.Account.Registration;

public class InputModel
{
    public string ReturnUrl { get; set; }
    
    [MaxLength(200)]
    [Display(Name="Email")]
    public string Email { get; set; }
    
    [MaxLength(200)]
    [DataType(DataType.Password)]
    [Display(Name="Password")]
    public string Password { get; set; }
    
    //TODO: Remove after invitation implementation
    public string Role { get; set; }
}