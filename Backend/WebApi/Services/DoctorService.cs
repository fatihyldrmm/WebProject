using System.Linq.Expressions;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepositoryManager _manager;

        public DoctorService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Doctor> GetAll(bool tracking = true)
        {
            return _manager.DoctorRepository.GetAll(tracking);
        }
        public IEnumerable<Doctor> GetWhere(Expression<Func<Doctor, bool>> method, bool tracking = true)
        {
            return _manager.DoctorRepository.GetWhere(method, tracking);
        }
        public Task<Doctor> GetSingleAsync(Expression<Func<Doctor, bool>> method, bool tracking = true)
        {
            return _manager.DoctorRepository.GetSingleAsync(method, tracking);
        }
        public Task<Doctor> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.DoctorRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Doctor model)
        {
            return _manager.DoctorRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Doctor> datas)
        {
            return _manager.DoctorRepository.AddRangeAsync(datas);
        }
        public bool Remove(Doctor model)
        {
            return _manager.DoctorRepository.Remove(model);
        }
        public bool RemoveRange(List<Doctor> datas)
        {
            return _manager.DoctorRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _manager.DoctorRepository.RemoveAsync(id);
        }
        public bool UpdateData(Doctor model)
        {
            return _manager.DoctorRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _manager.DoctorRepository.SaveAsync();
        }
    }
}
