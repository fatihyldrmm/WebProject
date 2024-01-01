using Microsoft.AspNetCore.Identity;

namespace WebClient.Interfaces.Services
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
    }
}
