namespace WebApi.Models.ViewModels.Appointment
{
    public class AppointmentCreateRequest
    {
        public DateTime AppointmentDay { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
    }
}
