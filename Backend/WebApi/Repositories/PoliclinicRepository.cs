using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Models.Entities;

namespace WebApi.Repositories
{
    public class PoliclinicRepository : RepositoryBase<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
