using HospitalManager.Client.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.Net.Http.Headers;
using SameSiteMode = Microsoft.AspNetCore.Http.SameSiteMode;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddRazorPages()
    .AddNewtonsoftJson();

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
    })
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.Cookie.SameSite = SameSiteMode.Lax;
    })
    .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
    {
        options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.Authority = "http://hm_idp:5001/";
        options.RequireHttpsMetadata = false;
        options.ClientId = "hospitalmanagerclient";
        options.ClientSecret = "secret";
        options.ResponseType = "code";
        options.SaveTokens = true;
        options.GetClaimsFromUserInfoEndpoint = true;
        options.Scope.Add("roles");
        options.Scope.Add("email");
        options.Scope.Add("hospitalmanagerapi.fullaccess");
        options.ClaimActions.MapJsonKey("Role", "Role");
        options.ClaimActions.MapJsonKey("Email", "Email");
        options.ClaimActions.DeleteClaim("idp");
        options.TokenValidationParameters = new()
        {
            NameClaimType = "given_name",
            RoleClaimType = "role"
        };
        options.Events.OnRedirectToIdentityProvider  = ctx =>
        {
            foreach (var query in ctx.HttpContext.Request.Query)
            {
                if (query.Key != "rgtkn")
                {
                    continue;
                }
                ctx.ProtocolMessage.Parameters.Add(query.Key, query.Value);
                return Task.CompletedTask;
            }
            return Task.CompletedTask;
        };
        
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