using Microsoft.AspNetCore.Identity;

namespace WebApi.Interfaces.Services
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
    }
}
