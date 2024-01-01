using System.Linq.Expressions;
using WebClient.Models.Entities;

namespace WebClient.Interfaces.Services
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Patient> GetWhere(Expression<Func<Patient, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Patient> GetSingleAsync(Expression<Func<Patient, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Patient> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(Patient model); // Data ekle.
        Task<bool> AddRangeAsync(List<Patient> datas); // Datalar ekle.
        bool Remove(Patient model); // Data çıkar.
        bool RemoveRange(List<Patient> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Patient model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
