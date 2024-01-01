using HospitalBackend.Context;
using HospitalBackend.Interfaces.Repositories;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
