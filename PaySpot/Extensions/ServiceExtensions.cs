using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PaySpot.Infrastructure.EF.Entity;
using System;
using PaySpot.Infrastructure.EF;

namespace PaySpot.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureIdentity(this IServiceCollection service, IConfiguration config)
        {
            var builder = service.AddIdentityCore<AppUsers>(x => x.User.RequireUniqueEmail = true);
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), service);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();

            return service;
        }
    }
}
