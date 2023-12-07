using Microsoft.AspNetCore.Identity;

namespace WebApi.Models.Common
{
    public class BaseEntity : IdentityUser
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
