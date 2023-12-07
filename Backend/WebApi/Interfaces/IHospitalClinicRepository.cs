using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IHospitalClinicRepository
    {
        public bool Add(HospitalClinic hc);
        public bool Save();
    }
}
