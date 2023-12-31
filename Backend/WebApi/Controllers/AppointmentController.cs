using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models.Entities;
using WebApi.Models.ViewModels.Appointment;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly IRepositoryManager _repositoryManager;


        public AppointmentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var appointments = _serviceManager.AppointmentService.GetAll();
            return Ok(appointments);
        }
        [HttpGet]
        [Route("GetByPatientId/{id}")]
        public IActionResult GetByPatientId(Guid id)
        {
            var appointments = _serviceManager.AppointmentService.GetByIdAsync(id);
            return Ok(appointments);
        }
        [HttpGet]
        [Route("GetByDoctorId/{id}")]
        public IActionResult GetByDoctorId(Guid id)
        {
            var appointments = _serviceManager.AppointmentService.GetByIdAsync(id);
            return Ok(appointments);
        }
        [HttpPost]
        [Route("addappointment")]
        public IActionResult AddAppointment([FromBody] AppointmentCreateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (model == null)
            {
                return BadRequest();
            }
            var hasAlredyAppointment = _repositoryManager.AppointmentRepository.GetWhere(i => i.DoctorId == model.DoctorId && i.AppointmentDay == model.AppointmentDay);
            if (hasAlredyAppointment != null)
            {
                return StatusCode(409, "Bu tarihte zaten bir randevu bulunmaktadır.");
            }
            var appointment = new Appointment
            {
                Id = Guid.NewGuid(),
                PatientId = model.PatientId,
                DoctorId = model.DoctorId,
                AppointmentDay = model.AppointmentDay
            };
            appointment.Doctor = _repositoryManager.DoctorRepository.GetByIdAsync(appointment.DoctorId.ToString()).Result;
            appointment.Patient = _repositoryManager.PatientRepository.GetByIdAsync(appointment.PatientId.ToString()).Result;
            _repositoryManager.AppointmentRepository.AddAsync(appointment);
            return Ok();
        }


    }
}
