using HospitalBackend.Context;
using HospitalBackend.Interfaces.Repositories;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
