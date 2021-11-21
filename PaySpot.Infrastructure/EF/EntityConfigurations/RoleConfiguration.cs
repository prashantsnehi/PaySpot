using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PaySpot.Utilities.Constants.Constants;

namespace PaySpot.Infrastructure.EF.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = Roles.Agent.ToString(), NormalizedName = Roles.Agent.ToString().ToUpper() },
                new IdentityRole { Name = Roles.User.ToString(), NormalizedName = Roles.User.ToString().ToUpper() },
                new IdentityRole { Name = Roles.Sales.ToString(), NormalizedName = Roles.Sales.ToString().ToUpper() },
                new IdentityRole { Name = Roles.Distributor.ToString(), NormalizedName = Roles.Distributor.ToString().ToUpper() },
                new IdentityRole { Name = Roles.SuperDistributor.ToString(), NormalizedName = Roles.SuperDistributor.ToString().ToUpper() },
                new IdentityRole { Name = Roles.Admin.ToString(), NormalizedName = Roles.Admin.ToString().ToUpper() },
                new IdentityRole { Name = Roles.SuperAdmin.ToString(), NormalizedName = Roles.SuperAdmin.ToString().ToUpper() }
            );
        }
    }
}
