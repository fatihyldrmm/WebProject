using WebApi.Models.Entities.Common;

namespace WebApi.Models.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDay { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public Policlinic Policlinic { get; set; }
        public Guid PoliclinicId { get; set; }
    }
}
