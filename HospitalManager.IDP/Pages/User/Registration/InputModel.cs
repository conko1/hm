using System.ComponentModel.DataAnnotations;

namespace HospitalManager.IDP.Pages.User.Registration;

public class InputModel
{
    public string ReturnUrl { get; set; }
    
    [MaxLength(200)]
    [Display(Name="Username")]
    public string Username { get; set; }
    
    [MaxLength(200)]
    [DataType(DataType.Password)]
    [Display(Name="Password")]
    public string Password { get; set; }
}