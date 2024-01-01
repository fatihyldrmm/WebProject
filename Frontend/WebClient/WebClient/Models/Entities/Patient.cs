using Microsoft.AspNetCore.Identity;
using WebClient.Models.Entities.Common;

namespace WebClient.Models.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
