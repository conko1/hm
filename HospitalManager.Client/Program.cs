using HospitalManager.Client.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

JsonWebTokenHandler.DefaultInboundClaimTypeMap.Clear();
builder.Services.AddAccessTokenManagement();

// create an HttpClient used for accessing the API
builder.Services.AddHttpClient("APIClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["HospitalManagerAPIUrl"]);
    client.DefaultRequestHeaders.Clear();
    client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
}).AddUserAccessTokenHandler();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
    }).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
    {
        options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.Authority = "http://hm_idp:5001/";
        options.RequireHttpsMetadata = false;
        options.ClientId = "hospitalmanagerclient";
        options.ClientSecret = "secret";
        options.ResponseType = "code";
        options.SaveTokens = true;
        // options.GetClaimsFromUserInfoEndpoint = true;
        options.Scope.Add("roles");
        options.Scope.Add("hospitalmanagerapi.fullaccess");
        // options.Scope.Add("offline_access");
        // // options.ClaimActions.Remove("aud");
        // // options.ClaimActions.DeleteClaim("sid");
        // // options.ClaimActions.DeleteClaim("idp");
        // options.ClaimActions.MapJsonKey("role", "role");
        // options.TokenValidationParameters = new()
        // {
        //     NameClaimType = "given_name",
        //     RoleClaimType = "role"
        // };
        
    });

builder.Services.AddAuthorization(options =>
{
    // Add policies
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();