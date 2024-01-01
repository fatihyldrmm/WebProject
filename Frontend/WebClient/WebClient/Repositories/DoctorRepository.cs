using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
