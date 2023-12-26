using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
