using System.Linq.Expressions;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IRepositoryManager _manager;

        public AppointmentService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Appointment> GetAll(bool tracking = true)
        {
            return _manager.AppointmentRepository.GetAll(tracking);
        }
        public IEnumerable<Appointment> GetWhere(Expression<Func<Appointment, bool>> method, bool tracking = true)
        {
            return _manager.AppointmentRepository.GetWhere(method, tracking);
        }
        public Task<Appointment> GetSingleAsync(Expression<Func<Appointment, bool>> method, bool tracking = true)
        {
            return _manager.AppointmentRepository.GetSingleAsync(method, tracking);
        }
        public Task<Appointment> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.AppointmentRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Appointment model)
        {
            return _manager.AppointmentRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Appointment> datas)
        {
            return _manager.AppointmentRepository.AddRangeAsync(datas);
        }
        public bool Remove(Appointment model)
        {
            return _manager.AppointmentRepository.Remove(model);
        }
        public bool RemoveRange(List<Appointment> datas)
        {
            return _manager.AppointmentRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _manager.AppointmentRepository.RemoveAsync(id);
        }
        public bool UpdateData(Appointment model)
        {
            return _manager.AppointmentRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _manager.AppointmentRepository.SaveAsync();
        }
    }
}
