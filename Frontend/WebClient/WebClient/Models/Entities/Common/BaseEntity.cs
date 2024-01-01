using Microsoft.AspNetCore.Identity;

namespace WebClient.Models.Entities.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
