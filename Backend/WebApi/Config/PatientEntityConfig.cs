﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models.Entities;

namespace WebApi.Config
{
    public class PatientEntityConfig : BaseEntityConfig<Patient>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(50).IsRequired();
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p=>p.Gender).IsRequired();
        }
    }
}
