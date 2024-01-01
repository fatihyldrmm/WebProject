using HospitalBackend.Models.Entities.Common;

namespace HospitalBackend.Models.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
