using Duende.IdentityServer;
using Duende.IdentityServer.Services;
using HospitalManager.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManager.IDP.Pages.User.Registration;

[AllowAnonymous]
[SecurityHeaders]
public class IndexModel : PageModel
{
    private readonly ILocalUserService _localUserService;
    private readonly IIdentityServerInteractionService _interaction;

    public IndexModel(ILocalUserService localUserService, IIdentityServerInteractionService interaction)
    {
        _localUserService = localUserService ?? throw new ArgumentNullException(nameof(localUserService));
        _interaction = interaction ?? throw new ArgumentNullException(nameof(interaction));
    }

    [BindProperty]
    public InputModel Input { get; set; }
    
    public IActionResult OnGet(string returnUrl)
    {
        BuildModel(returnUrl);

        return Page();
    }

    private void BuildModel(string returnUrl)
    {
        Input = new InputModel
        {
            ReturnUrl = returnUrl
        };
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            BuildModel(Input.ReturnUrl);
            return Page(); 
        }

        var userToCreate = new Entities.User
        {
            Username = Input.Username,
            Subject = Guid.NewGuid().ToString(),
            IsActive = true
        };
        
        // userToCreate.Claims.Add(new Entities.UserClaim()
        // {
        //     Type = "Role",
        //     Value = 
        // });
        
        _localUserService.AddUser(userToCreate, Input.Password);
        await _localUserService.SaveChangesAsync();

        var isUser = new IdentityServerUser(userToCreate.Subject)
        {
            DisplayName = Input.Username,
        };
        await HttpContext.SignInAsync(isUser);

        if (_interaction.IsValidReturnUrl(Input.ReturnUrl) || Url.IsLocalUrl(Input.ReturnUrl))
        {
            return Redirect(Input.ReturnUrl);
        }

        return Redirect("~/");
    }
}