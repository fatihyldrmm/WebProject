using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(p => p.Id);


            builder.HasData(
                    new Doctor() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow },
                    new Doctor() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow }
                );
        }
    }
}
