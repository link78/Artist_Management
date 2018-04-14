using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {
        // adding identity resources
        public static IEnumerable<IdentityResource> GetIdentityResource()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        // adding Api Resources

        public static IEnumerable<ApiResource> ApiResource()
        {
            return new List<ApiResource>
            {
                new IdentityServer4.Models.ApiResource("LimCode","Lim Code")
            };
        }

        // adding Clients

        public static IEnumerable<Client> GetClient()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId="mvcApp",
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ImplicitAndClientCredentials,
                    RedirectUris= {"https://localhost:44340/signin-oidc"},
                    PostLogoutRedirectUris = {"https://localhost:44340/signout-callback-oidc"},

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "limCode"
                    }
                }
            };
        }

        public static IEnumerable<TestUser> GetTestUser()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId="1",
                    Username= "admin_P@example.com",
                    Password = "Admin1234!@",

                    Claims = new List<Claim>
                    {
                        new Claim("name","Admin"),
                        new Claim("email","admin_P@example.com")
                    }

                },
                new TestUser
                {
                    SubjectId="1",
                    Username= "lim@example.com",
                    Password = "Lim1234!@",

                    Claims = new List<Claim>
                    {
                        new Claim("name","Lim"),
                        new Claim("email","Lim@example.com")
                    }

                }
            };
        }
    }
}
