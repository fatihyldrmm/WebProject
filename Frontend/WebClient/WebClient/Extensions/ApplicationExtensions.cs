using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Interfaces.Services;
using WebClient.Repositories;
using WebClient.Services;

namespace WebClient.Extensions
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
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
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
        public static void ConfigureServiceRegisteration(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IPoliclinicService, PoliclinicService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
        }
        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;
            });
        }

        public static void ConfigureLocalization(this IApplicationBuilder app)
        {
            app.UseRequestLocalization(options =>
            {
                options.AddSupportedCultures("tr-TR", "us-US")
                    .AddSupportedUICultures("tr-TR", "us-US")
                    .SetDefaultCulture("tr-TR");
            });
        }

        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
        {
            const string adminEmail = "g211210379@sakarya.edu.tr";
            const string adminPassword = "sau";

            //UserMAnager
            UserManager<IdentityUser> userManager = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            //RoleManager
            RoleManager<IdentityRole> roleManager = app
                .ApplicationServices
                .CreateAsyncScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            IdentityUser user = await userManager.FindByEmailAsync(adminEmail);
            if (user is null)
            {
                user = new IdentityUser()
                {
                    Email = "g211210379@sakarya.edu.tr",
                    PhoneNumber = "5524563602",
                    UserName = "Admin"
                };

                var result = await userManager.CreateAsync(user, adminPassword);
                if (!result.Succeeded)
                    throw new Exception("Admin user could not created.");

                var roleResult = await userManager.AddToRolesAsync(user,
                    roleManager
                        .Roles
                        .Select(r => r.Name)
                        .ToList()
                );

                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with role defination for admin");
            }

        }
    }
}
