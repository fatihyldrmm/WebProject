namespace WebClient.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IDoctorRepository DoctorRepository { get; }
        IPatientRepository PatientRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        IPoliclinicRepository PoliclinicRepository { get; }
        public void Save();
    }
}
