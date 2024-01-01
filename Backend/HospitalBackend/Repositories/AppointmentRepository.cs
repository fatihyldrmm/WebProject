using HospitalBackend.Context;
using HospitalBackend.Interfaces.Repositories;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
