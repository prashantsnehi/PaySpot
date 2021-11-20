using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaySpot.Infrastructure.EF.Entity;
using PaySpot.Infrastructure.EF.EntityConfigurations;

namespace PaySpot.Infrastructure.EF
{
    public class DatabaseContext : IdentityDbContext<AppUsers>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
