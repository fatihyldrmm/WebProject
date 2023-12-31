using Microsoft.AspNetCore.Mvc;
using WebClient.Models.ViewModels.Appointment;

namespace WebClient.Areas.User.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RandevuAl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RandevuAl(AppointmentCreateVM model)
        {
            return View();
        }
    }
}
