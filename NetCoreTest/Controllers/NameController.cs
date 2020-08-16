using Microsoft.AspNetCore.Mvc;
using NetCoreTest.Services;

namespace NetCoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly INameService _nameService;

        public NameController(INameService nameService)
        {
            _nameService = nameService;
        }

        [Route("alive")]
        [HttpGet]
        public IActionResult Alive()
        {
            return Content("Api Alive");
        }
        
        [HttpGet]
        public StatusCodeResult Get(string name)
        {
            var isValidName = _nameService.isValidName(name);
            if (isValidName)
                return Ok();
            else
                return BadRequest();
        }
    }
}