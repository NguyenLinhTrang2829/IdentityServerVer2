//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.DependencyInjection;
//using IdentityServer;
//using IdentityServer.Stores;

//namespace IdentityServer.Core
//{
//    public class DependencyInjection
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//            // Add ASP.NET Identity
//            services.AddIdentity<ApplicationUser, IdentityRole>()
//                    .AddEntityFrameworkStores<ApplicationDbContext>()
//                    .AddDefaultTokenProviders();

//            // Add IdentityServer
//            services.AddIdentityServer()
//                    .AddDeveloperSigningCredential()
//                    .AddInMemoryPersistedGrants()
//                    .AddInMemoryIdentityResources(Config.GetIdentityResources())
//                    .AddInMemoryApiResources(Config.GetApiResources())
//                    .AddInMemoryClients(Config.GetClients())
//                    .AddAspNetIdentity<ApplicationUser>(); // Integrate with ASP.NET Identity
//        }
//    }
//}
