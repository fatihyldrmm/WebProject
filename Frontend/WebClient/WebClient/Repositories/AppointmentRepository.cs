using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
