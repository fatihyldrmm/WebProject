using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class PoliclinicEntityConfig : BaseEntityConfig<Policlinic>
    {
        public override void Configure(EntityTypeBuilder<Policlinic> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
        }
    }
}
