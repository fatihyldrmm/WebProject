using System.Linq.Expressions;
using WebApi.Models.Entities;

namespace WebApi.Interfaces.Services
{
    public interface IPoliclinicService
    {
        IEnumerable<Policlinic> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Policlinic> GetWhere(Expression<Func<Policlinic, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Policlinic> GetSingleAsync(Expression<Func<Policlinic, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Policlinic> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(Policlinic model); // Data ekle.
        Task<bool> AddRangeAsync(List<Policlinic> datas); // Datalar ekle.
        bool Remove(Policlinic model); // Data çıkar.
        bool RemoveRange(List<Policlinic> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Policlinic model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
