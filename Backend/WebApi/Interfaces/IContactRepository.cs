using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAll();
        bool Add(Contact contact);

        bool Save();

    }
}
