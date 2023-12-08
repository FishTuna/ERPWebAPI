using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpController : ControllerBase
    {
        [HttpGet()]
        public IActionResult CheckConnection()
        {
            return Ok("Succeeded");
        }
    }
}
