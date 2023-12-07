using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAuthService _authService;

        public DoctorController(IDoctorRepository doctorRepository, IAuthService authService)
        {
            _doctorRepository = doctorRepository;
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var doctors =  _doctorRepository.GetAll();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id.ToString());
            if (doctor == null)
            {
                return NotFound();
            }
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Doctor doctor)
        {
            await _doctorRepository.AddAsync(doctor);
            return CreatedAtAction(nameof(Get), new { id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Doctor doctor)
        {
            if (id != doctor.Id)
            {
                return BadRequest();
            }
            _doctorRepository.UpdateData(doctor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id.ToString());
            if (doctor == null)
            {
                return NotFound();
            }
            _doctorRepository.Remove(doctor);
            return NoContent();
        }
    }
}
