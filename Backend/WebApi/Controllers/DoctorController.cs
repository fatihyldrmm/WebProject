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
        private readonly IRepositoryManager _manager;
        private readonly IAuthService _authService;

        public DoctorController(IRepositoryManager manager, IAuthService authService)
        {
            _manager = manager;
            _authService = authService;
        }



    }
}
