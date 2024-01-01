using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces.Repositories;
using WebApi.Interfaces.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliclinicController : ControllerBase
    {
        private readonly IRepositoryManager _manager;
        private readonly IAuthService _authService;

        public PoliclinicController(IRepositoryManager manager, IAuthService authService)
        {
            _manager = manager;
            _authService = authService;
        }

        [HttpGet]
        [Route("getallpoliclinics")]
        public IActionResult GetAllPoliclinics()
        {
            try
            {
                var policlinics = _manager.PoliclinicRepository.GetAll(); // Asenkron metod
                return Ok(policlinics);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
