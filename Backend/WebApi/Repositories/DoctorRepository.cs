using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;

namespace WebApi.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly HospitalDbContext _context;
        public DoctorRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public bool Add(Doctor doctor)
        {
            _context.Add(doctor);
            return Save();
        }

        public bool Delete(Doctor doctor)
        {
            _context.Remove(doctor);
            return Save();
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Doctor doctor)
        {
            _context.Update(doctor);
            return Save();
        }

        public Doctor GetDoctorById(int doctorId)
        {
            return _context.Doctors.Find(doctorId);
        }
    }
}
