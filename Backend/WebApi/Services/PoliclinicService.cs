using System.Linq.Expressions;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class PoliclinicService : IPoliclinicService
    {
        private readonly IRepositoryManager _manager;

        public PoliclinicService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Policlinic> GetAll(bool tracking = true)
        {
            return _manager.PoliclinicRepository.GetAll(tracking);
        }
        public IEnumerable<Policlinic> GetWhere(Expression<Func<Policlinic, bool>> method, bool tracking = true)
        {
            return _manager.PoliclinicRepository.GetWhere(method, tracking);
        }
        public Task<Policlinic> GetSingleAsync(Expression<Func<Policlinic, bool>> method, bool tracking = true)
        {
            return _manager.PoliclinicRepository.GetSingleAsync(method, tracking);
        }
        public Task<Policlinic> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.PoliclinicRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Policlinic model)
        {
            return _manager.PoliclinicRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Policlinic> datas)
        {
            return _manager.PoliclinicRepository.AddRangeAsync(datas);
        }
        public bool Remove(Policlinic model)
        {
            return _manager.PoliclinicRepository.Remove(model);
        }
        public bool RemoveRange(List<Policlinic> datas)
        {
            return _manager.PoliclinicRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _manager.PoliclinicRepository.RemoveAsync(id);
        }
        public bool UpdateData(Policlinic model)
        {
            return _manager.PoliclinicRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _manager.PoliclinicRepository.SaveAsync();
        }
    }
}
