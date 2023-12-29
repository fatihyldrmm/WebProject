namespace WebApi.Interfaces.Services
{
    public interface IServiceManager
    {
        IPoliclinicService PoliclinicService { get; }
        IDoctorService DoctorService { get; }
        IPatientService PatientService { get; }
        IAppointmentService AppointmentService { get; }
        IAuthService AuthService { get; }
    }
}
