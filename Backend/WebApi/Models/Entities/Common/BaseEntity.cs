using Microsoft.AspNetCore.Identity;

namespace WebApi.Models.Entities.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
