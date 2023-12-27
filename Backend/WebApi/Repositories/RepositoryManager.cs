using WebApi.Interfaces.Repositories;

namespace WebApi.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientrRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IPoliclinicRepository _policlinicRepository;

        public RepositoryManager(IDoctorRepository doctorRepository, IPatientRepository patientrRepository, IAppointmentRepository appointmentRepository, IPoliclinicRepository policlinicRepository)
        {
            _doctorRepository = doctorRepository;
            _patientrRepository = patientrRepository;
            _appointmentRepository = appointmentRepository;
            _policlinicRepository = policlinicRepository;
        }

        public IDoctorRepository DoctorRepository => _doctorRepository;

        public IPatientRepository PatientRepository => _patientrRepository;

        public IAppointmentRepository AppointmentRepository => _appointmentRepository;

        public IPoliclinicRepository PoliclinicRepository => _policlinicRepository;
    }
}
