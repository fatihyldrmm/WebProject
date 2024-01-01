using HospitalBackend.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalBackend.Config
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
