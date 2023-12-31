using Microsoft.AspNetCore.Mvc;

namespace WebClient.Areas.User.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
