using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
