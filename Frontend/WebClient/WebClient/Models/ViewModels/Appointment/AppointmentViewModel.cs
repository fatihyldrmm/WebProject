namespace WebClient.Models.ViewModels.Appointment
{
    public class AppointmentViewModel
    {
        public DateTime AppointmentDay { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
    }
}
