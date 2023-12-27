using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
