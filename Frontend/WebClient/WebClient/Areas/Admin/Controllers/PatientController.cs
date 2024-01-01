using Microsoft.AspNetCore.Mvc;

namespace WebClient.Areas.Admin.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
