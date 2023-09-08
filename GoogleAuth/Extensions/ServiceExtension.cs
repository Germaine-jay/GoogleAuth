using GoogleAuth.Context;
using GoogleAuth.Entities;
using Microsoft.AspNetCore.Identity;



namespace GoogleAuth.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AunctionAppDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication()
               .AddGoogle(options =>
               {
                   options.ClientId = configuration["Authentication:Google:ClientId"];
                   options.ClientSecret = configuration["Authentication:Google:ClientSecret"];
               });

        }
    }
}
