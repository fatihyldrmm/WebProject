using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Repositories;

namespace WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("WebApi"));

                options.EnableSensitiveDataLogging(true);
            });

            //var seedData = new SeedData();
            //seedData.SeedAsync(configuration).GetAwaiter().GetResult();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options=>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<HospitalDbContext>();
        }

        //public static void ConfigureSession(this IServiceCollection services)
        //{
        //    services.AddDistributedMemoryCache();
        //    services.AddSession(options =>
        //    {
        //        options.Cookie.Name = "StoreApp.Session";
        //        options.IdleTimeout = TimeSpan.FromMinutes(10);
        //    });
        //    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        //    services.AddScoped<Cart>(c => SessionCart.GetCart(c)); // Cart nesnesinin yaşam döngüsü ile ilgili ek çalışma yapılacak.

        //}

        public static void ConfigureRepositoryRegisteration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IPoliclinicRepository, PoliclinicRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();

        }
        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;
            });
        }
    }
}
