using Bogus;
using HospitalBackend.Models.Entities;
using HospitalBackend.Models.EntityFeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HospitalBackend.Context
{
    public class SeedData
    {
        //private static List<Patient> GetPatients()
        //{
        //    List<string> gender = PatientGenderFeed.Gender();
        //    var result = new Faker<Patient>("tr")
        //            .RuleFor(i => i.Id, i => Guid.NewGuid())
        //            .RuleFor(i => i.CreatedDate,
        //                    i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
        //            .RuleFor(i => i.Name, i => i.Person.FirstName)
        //            .RuleFor(i => i.Surname, i => i.Person.LastName)
        //            .RuleFor(i => i.BirthDate, i => i.Person.DateOfBirth)
        //            .RuleFor(i => i.Gender, i => i.PickRandom(gender))
        //        .Generate(500);

        //    return result;
        //}

        //public static List<Policlinic> GetPoliclinicsAsync()
        //{
        //    List<string> policlinicNames = PoliclinicNamesFeed.PoliclinicNames();
        //    int counter = 0;
        //    int policlinicCount = policlinicNames.Count;
        //    var result = new Faker<Policlinic>("tr")
        //            .RuleFor(i => i.Id, i => Guid.NewGuid())
        //            .RuleFor(i => i.CreatedDate,
        //                                       i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
        //            .RuleFor(i => i.Name, i => policlinicNames[counter++])
        //        .Generate(policlinicCount);

        //    return result;
        //}

        //private static List<Doctor> GetDoctorsAsync()
        //{
        //    var policlinics = GetPoliclinicsAsync();
        //    var policlinicIds = policlinics.Select(i => i.Id);

        //    var result = new Faker<Doctor>("tr")
        //            .RuleFor(i => i.Id, i => Guid.NewGuid())
        //            .RuleFor(i => i.CreatedDate,
        //                        i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
        //            .RuleFor(i => i.Name, i => i.Person.FirstName)
        //            .RuleFor(i => i.Surname, i => i.Person.LastName)
        //            .RuleFor(i => i.PoliclinicId, i => i.PickRandom(policlinicIds))
        //        .Generate(100);
        //    return result;
        //}
        //private static List<Appointment> GetAppointments()
        //{
        //    var doctors = GetDoctorsAsync();
        //    var doctorIds = doctors.Select(i => i.Id);

        //    var patients = GetPatients();
        //    var patientIds = patients.Select(i => i.Id);

        //    var guids = Enumerable.Range(0, 150).Select(i => Guid.NewGuid()).ToList();
        //    int counter = 0;

        //    var result = new Faker<Appointment>("tr")
        //            .RuleFor(i => i.Id, i => guids[counter++])
        //            .RuleFor(i => i.CreatedDate,
        //                        i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
        //            .RuleFor(i => i.AppointmentDay, i => i.Date.Between(DateTime.Now, DateTime.Now.AddDays(30)))
        //            .RuleFor(i => i.PatientId, i => i.PickRandom(patientIds))
        //            .RuleFor(i => i.DoctorId, i => i.PickRandom(doctorIds))
        //        .Generate(150);

        //    return result;
        //}

        public async Task SeedAsync(IConfiguration configuration)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();
            dbContextBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            var context = new HospitalDbContext(dbContextBuilder.Options);


            List<string> policlinicNames = PoliclinicNamesFeed.PoliclinicNames();
            int counter = 0;
            int policlinicCount = policlinicNames.Count;
            var policlinics = new Faker<Policlinic>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                                               i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.Name, i => policlinicNames[counter++])
                .Generate(policlinicCount);

            await context.Policlinics.AddRangeAsync(policlinics);


            List<string> gender = PatientGenderFeed.Gender();
            var patients = new Faker<Patient>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                            i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.Name, i => i.Person.FirstName)
                    .RuleFor(i => i.Surname, i => i.Person.LastName)
                    .RuleFor(i => i.BirthDate, i => i.Person.DateOfBirth)
                    .RuleFor(i => i.Gender, i => i.PickRandom(gender))
                .Generate(500);

            await context.Patients.AddRangeAsync(patients);


            var policlinicIds = policlinics.Select(i => i.Id);

            var doctors = new Faker<Doctor>("tr")
                    .RuleFor(i => i.Id, i => Guid.NewGuid())
                    .RuleFor(i => i.CreatedDate,
                                i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.Name, i => i.Person.FirstName)
                    .RuleFor(i => i.Surname, i => i.Person.LastName)
                    .RuleFor(i => i.PoliclinicId, i => i.PickRandom(policlinicIds))
                .Generate(100);

            await context.Doctors.AddRangeAsync(doctors);


            var doctorIds = doctors.Select(i => i.Id);


            var patientIds = patients.Select(i => i.Id);

            var guids = Enumerable.Range(0, 150).Select(i => Guid.NewGuid()).ToList();
            int counter1 = 0;

            var appointments = new Faker<Appointment>("tr")
                    .RuleFor(i => i.Id, i => guids[counter1++])
                    .RuleFor(i => i.CreatedDate,
                                i => i.Date.Between(DateTime.Now.AddDays(-100), DateTime.Now))
                    .RuleFor(i => i.AppointmentDay, i => i.Date.Between(DateTime.Now, DateTime.Now.AddDays(30)))
                    .RuleFor(i => i.PatientId, i => i.PickRandom(patientIds))
                    .RuleFor(i => i.DoctorId, i => i.PickRandom(doctorIds))
                .Generate(150);

            await context.Appointments.AddRangeAsync(appointments);

            await context.SaveChangesAsync();
        }
    }
}
