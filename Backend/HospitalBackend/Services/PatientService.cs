using System.Linq.Expressions;
using HospitalBackend.Interfaces.Repositories;
using HospitalBackend.Interfaces.Services;
using HospitalBackend.Models.Entities;

namespace HospitalBackend.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepositoryManager _manager;

        public PatientService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Patient> GetAll(bool tracking = true)
        {
            return _manager.PatientRepository.GetAll(tracking);
        }
        public IEnumerable<Patient> GetWhere(Expression<Func<Patient, bool>> method, bool tracking = true)
        {
            return _manager.PatientRepository.GetWhere(method, tracking);
        }
        public Task<Patient> GetSingleAsync(Expression<Func<Patient, bool>> method, bool tracking = true)
        {
            return _manager.PatientRepository.GetSingleAsync(method, tracking);
        }
        public Task<Patient> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.PatientRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Patient model)
        {
            return _manager.PatientRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Patient> datas)
        {
            return _manager.PatientRepository.AddRangeAsync(datas);
        }
        public bool Remove(Patient model)
        {
            return _manager.PatientRepository.Remove(model);
        }
        public bool RemoveRange(List<Patient> datas)
        {
            return _manager.PatientRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _manager.PatientRepository.RemoveAsync(id);
        }
        public bool UpdateData(Patient model)
        {
            return _manager.PatientRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _manager.AppointmentRepository.SaveAsync();
        }
    }
}
