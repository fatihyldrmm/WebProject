using Microsoft.AspNetCore.Identity;

namespace HospitalBackend.Interfaces.Services
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
    }
}
