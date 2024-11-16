using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace HospitalManager.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles", "Your role", new [] {"role"}),
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource(
                "hospitalmanagerapi", 
                "Hospital manage API",
                new [] { "roles" }
            )
            {
                Scopes = { "hospitalmanagerapi.fullaccess" }
            }
        };
    
    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope("hospitalmanagerapi.fullaccess"),
            };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client()
            {
                ClientName = "Hospital manager",
                ClientId = "hospitalmanagerclient",
                AllowedGrantTypes = GrantTypes.Code,
                AllowOfflineAccess = true,
                UpdateAccessTokenClaimsOnRefresh = true,
                RedirectUris =
                {
                    "http://localhost:5123/signin-oidc",
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "roles",
                    "hospitalmanagerapi.fullaccess",
                },
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                }
            }
        };
}