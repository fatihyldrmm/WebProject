using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Config
{
    public class DoctorConfig : BaseEntityConfig<Doctor>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(50).IsRequired();
            builder.HasOne(p => p.Policlinic).
                    WithMany(p => p.Doctors).
                    HasForeignKey(p => p.PoliclinicId);

        }
    }
}
