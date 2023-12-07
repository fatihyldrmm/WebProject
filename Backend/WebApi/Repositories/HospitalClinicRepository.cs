using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;

namespace WebApi.Repository
{
    public class HospitalClinicRepository : IHospitalClinicRepository
    {
        private readonly HospitalDbContext _context;
        public HospitalClinicRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public bool Add(HospitalClinic hc)
        {
            _context.Add(hc);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
