using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        public List<Hospital> GetAllHospitals();
        Task<Hospital> GetByIdAsync(int id);
        bool Add(Hospital hospital);
        bool Update(Hospital hospital);
        bool Delete(Hospital hospital);
        bool Save();
        public Hospital GetHospitalById(int hospitalId);
    }
}
