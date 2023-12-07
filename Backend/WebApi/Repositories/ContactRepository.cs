using WebApi.Context;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly HospitalDbContext _context;
        public ContactRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public bool Add(Contact contact)
        {
            _context.Add(contact);
            return Save();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
