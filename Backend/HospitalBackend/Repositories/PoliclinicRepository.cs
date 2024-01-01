using HospitalBackend.Context;
using HospitalBackend.Interfaces.Repositories;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Repositories
{
    public class PoliclinicRepository : RepositoryBase<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
