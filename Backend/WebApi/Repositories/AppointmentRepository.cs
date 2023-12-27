using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
