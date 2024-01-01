using System.Linq.Expressions;
using WebClient.Models.Entities;

namespace WebClient.Interfaces.Services
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Appointment> GetWhere(Expression<Func<Appointment, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Appointment> GetSingleAsync(Expression<Func<Appointment, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Appointment> GetByIdAsync(Guid id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(Appointment model); // Data ekle.
        Task<bool> AddRangeAsync(List<Appointment> datas); // Datalar ekle.
        bool Remove(Appointment model); // Data çıkar.
        bool RemoveRange(List<Appointment> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Appointment model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
