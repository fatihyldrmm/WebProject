using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Context;
using WebClient.Interfaces.Repositories;
using WebClient.Models.ViewModels.Appointment;

namespace WebClient.Areas.User.Controllers
{
    [Area("User")]
    public class AppointmentController : Controller
    {
        private readonly IRepositoryManager _manager;

        public AppointmentController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThankYouPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TakeAppointment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TakeAppointment(AppointmentCreateRequest model)
        {
            //if (ModelState.IsValid)
            //{
            //    // Randevuyu oluştur
            //    var appointment = new Appointment
            //    {
            //        // Modelinizin özelliklerine göre randevu nesnesini doldurun
            //        // Örnek:
            //        DoctorId = model.DoctorId,
            //        Date = model.Date,
            //        // Diğer özellikler...
            //    };

            //    await _appointmentRepository.AddAsync(appointment);

            //    // Randevu kaydedildikten sonra teşekkür sayfasına yönlendir
            //    return RedirectToAction("ThankYouPage");
            //}

            //// Eğer ModelState geçerli değilse, formu tekrar göster
            //return View(model);
            return View();
        }
    }
}
