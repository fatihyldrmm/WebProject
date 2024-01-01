using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Repositories
{
    public class PoliclinicRepository : RepositoryBase<Policlinic>, IPoliclinicRepository
    {
        public PoliclinicRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
