using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebClient.Models.ViewModels.Appointment
{
    public class AppointmentCreateViewModel
    {
        public List<SelectListItem> Policlinics { get; set; }
        public List<SelectListItem> Doctors { get; set; }
        public DateTime AppointmentDate { get; set; }

        public AppointmentCreateViewModel()
        {
            Policlinics = new List<SelectListItem>();
            Doctors = new List<SelectListItem>();
        }
    }
}
