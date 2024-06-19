using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;

namespace TeamHost.DAL
{
    public static class RegisterDalServices
    {
        public static void RegisterServices(this WebApplicationBuilder builder)
        {

            string? envVariable = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(envVariable);
            Console.ResetColor();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddIdentity<AppUser, IdentityRole>()
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<AppDbContext>();

        }
    }
}
