using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Models;
using WebApi.Models.Common;

namespace WebApi.Context
{
    public class HospitalDbContext : IdentityDbContext<BaseEntity>
    {

        public DbSet<Doctor> Doctors { get; set; }    
 
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {


        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir.
            // Update operasyonlarında Track Edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                        .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
