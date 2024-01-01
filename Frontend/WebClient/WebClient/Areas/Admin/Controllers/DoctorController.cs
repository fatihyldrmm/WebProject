using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly IRepositoryManager _manager;
        public DoctorController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Doktorlar()
        {
            var doktors = _manager.DoctorRepository.GetAll().ToList();
            foreach (var doctor in doktors)
            {
                doctor.Policlinic = await _manager.PoliclinicRepository.GetByIdAsync(doctor.PoliclinicId.ToString());
                doctor.Appointments = await _manager.AppointmentRepository.GetAll().Where(x => x.DoctorId == doctor.Id).ToListAsync();
            }
            return View(doktors);
        }

        public async Task<IActionResult> Randevuları([FromRoute(Name = "id")]Guid id)
        {
            var doktor = await _manager.DoctorRepository.GetByIdAsync(id.ToString());
            doktor.Appointments = await _manager.AppointmentRepository.GetAll().Where(x => x.DoctorId == doktor.Id).ToListAsync();
            foreach (var item in doktor.Appointments)
            {
                item.Patient = await _manager.PatientRepository.GetByIdAsync(item.PatientId.ToString());
            }
            return View(doktor);
        }

        //public async Task<IActionResult> RandevuSil([FromRoute(Name = "id")]Guid id)
        //{
        //    var randevu = await _manager.AppointmentRepository.GetByIdAsync(id.ToString());
        //    await _manager.AppointmentRepository.DeleteAsync(randevu);
        //    return RedirectToAction("Randevuları", new { id = randevu.DoctorId });
        //}

        public async Task<IActionResult> DoktorEkle()
        {
            ViewBag.Policlinics = await _manager.PoliclinicRepository.GetAll().ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DoktorEkle(Doctor doctor)
        {
            await _manager.DoctorRepository.AddAsync(doctor);
            return RedirectToAction("Doktorlar");
        }

    }
}
