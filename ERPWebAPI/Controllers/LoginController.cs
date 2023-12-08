using ERPWebAPI.BL.Abstract.Session;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ERPWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly ILoginInfoService _loginservice;


        public LoginController(ILoginInfoService loginService)
        {
            _loginservice = loginService;

        }
        [HttpPost("APPLOGIN/{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult AppLogin([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _loginservice.SendLoginInfo(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("APPLOGOFF/{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult AppLogoff([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _loginservice.SendLogOffInfo(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
