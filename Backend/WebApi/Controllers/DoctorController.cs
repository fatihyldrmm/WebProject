using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;
using WebApi.Models.Entities;

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

    }
}
