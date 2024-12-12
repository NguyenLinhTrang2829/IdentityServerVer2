using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;
using System.Security.Claims;

public static class Config
{
    public static IEnumerable<Client> Clients =>
      new List<Client>
      {
        new Client
        {
            ClientId = "client_id",
            AllowedGrantTypes = GrantTypes.Code,
            RedirectUris = { "https://localhost:5002/signin-oidc" }, // URL hợp lệ
            PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },
            AllowedScopes = { "openid", "profile", "api1" },
            RequirePkce = true,
            ClientSecrets = { new Secret("client_secret".Sha256()) }
        }
      };


    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("api1", "My API")
        };

    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new List<ApiResource>();

    public static List<TestUser> Users =>
        new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1",                                                                                                                                            
                Username = "alice",
                Password = "password",
                Claims = { new Claim("name", "Alice"), new Claim("website", "https://alice.com") }
            }
        };
}
