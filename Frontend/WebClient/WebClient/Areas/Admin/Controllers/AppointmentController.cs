using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebClient.Interfaces.Repositories;
using WebClient.Models.Entities;

namespace WebClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppointmentController : Controller
    {
        private readonly IRepositoryManager _manager;
        public AppointmentController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Randevular()
        {
            var appointments = _manager.AppointmentRepository.GetAll().ToList();
            foreach (var item in appointments)
            {
                item.Doctor = await _manager.DoctorRepository.GetByIdAsync(item.DoctorId.ToString());
                item.Patient = await _manager.PatientRepository.GetByIdAsync(item.PatientId.ToString());
                item.Doctor.Policlinic = await _manager.PoliclinicRepository.GetByIdAsync(item.Doctor.PoliclinicId.ToString());
            }
            return View(appointments);
        }
    }
}
