using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Config
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() { Name = "Doctor", NormalizedName = "DOCTOR" },
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}
