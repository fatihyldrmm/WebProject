using System.Linq.Expressions;
using WebClient.Models.Entities;

namespace WebClient.Interfaces.Services
{
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Doctor> GetWhere(Expression<Func<Doctor, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Doctor> GetSingleAsync(Expression<Func<Doctor, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Doctor> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(Doctor model); // Data ekle.
        Task<bool> AddRangeAsync(List<Doctor> datas); // Datalar ekle.
        bool Remove(Doctor model); // Data çıkar.
        bool RemoveRange(List<Doctor> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Doctor model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
