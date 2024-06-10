using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.RPT
{
    [Route("api/RPT/[controller]")]
    [ApiController]
    public class ReportParamController : ControllerBase
    {
        readonly IRPT_ReportParamService<RPT_ReportParam, SqlResult> rPT_ReportParamService;

        public ReportParamController(IRPT_ReportParamService<RPT_ReportParam, SqlResult> _rPT_ReportParamService)
        {
            rPT_ReportParamService = _rPT_ReportParamService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "RPT,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = rPT_ReportParamService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
