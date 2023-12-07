
using WebApi.Models;

namespace WebClient.ViewModels
{
    public class ClinicViewModel
    {
        public int SelectedClinicId { get; set; }
        public int SelectedHospitalId { get; set; }
        public List<Clinic> Clinics { get; set; } = new List<Clinic>();
        public List<Hospital> Hospitals { get; set; } = new List<Hospital>();

        
    }
}
