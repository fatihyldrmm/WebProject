using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using WebApi.Context;

namespace WebApi.Repository
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly HospitalDbContext _context;
        public HospitalRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public List<Hospital> GetAllHospitals()
        {
            return _context.Hospitals.ToList();
        }

        public bool Add(Hospital hospital)
        {
            _context.Add(hospital);
            return Save();
        }

        public bool Delete(Hospital hospital)
        {
            _context.Remove(hospital);
            return Save();
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            return await _context.Hospitals.ToListAsync();
        }

        public async Task<Hospital> GetByIdAsync(int id)
        {
            return await _context.Hospitals.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Hospital hospital)
        {
            _context.Update(hospital);
            return Save();
        }

        public Hospital GetHospitalById(int hospitalId)
        {
           
            return _context.Hospitals.FirstOrDefault(h => h.Id == hospitalId);
        }
    }
}
