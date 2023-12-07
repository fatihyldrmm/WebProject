using Microsoft.AspNetCore.Identity;

namespace WebApi.Models
{
    public class Citizen : IdentityUser
    {
        public ICollection<Appointment> Appointments { get; set; }
    }
}
