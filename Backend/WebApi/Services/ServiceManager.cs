using WebApi.Interfaces.Services;

namespace WebApi.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IPoliclinicService _policlinicService;
        private readonly IDoctorService _doctorService;
        private readonly IPatientService _patientService;
        private readonly IAppointmentService _appointmentService;
        private readonly IAuthService _authService;

        public ServiceManager(IAuthService authService, IAppointmentService appointmentService, IPatientService patientService, IDoctorService doctorService, IPoliclinicService policlinicService)
        {
            _authService = authService;
            _appointmentService = appointmentService;
            _patientService = patientService;
            _doctorService = doctorService;
            _policlinicService = policlinicService;
        }

        public IPoliclinicService PoliclinicService => _policlinicService;

        public IDoctorService DoctorService => _doctorService;

        public IPatientService PatientService => _patientService;

        public IAppointmentService AppointmentService => _appointmentService;

        public IAuthService AuthService => _authService;
    }
}
