using Microsoft.AspNetCore.Mvc;

namespace WebClient.Areas.Admin.Controllers
{
    public class PoliclinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
