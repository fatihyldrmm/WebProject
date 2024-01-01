using HospitalBackend.Models.Entities.Common;
using Microsoft.AspNetCore.Identity;

namespace HospitalBackend.Models.Entities
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
