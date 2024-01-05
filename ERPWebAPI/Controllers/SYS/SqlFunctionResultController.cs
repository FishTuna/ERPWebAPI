using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.SYS
{
    [Route("api/SYS/[controller]")]
    [ApiController]
    public class SqlFunctionResultController : ControllerBase
    {
        private readonly ISYS_SqlFunctionResultService<SYS_SqlFunctionResult, SqlResult> _FunctionResultService;

        public SqlFunctionResultController(ISYS_SqlFunctionResultService<SYS_SqlFunctionResult, SqlResult> FunctionResultService)
        {
            _FunctionResultService = FunctionResultService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult Get([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _FunctionResultService.GetDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
