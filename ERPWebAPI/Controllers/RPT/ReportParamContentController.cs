using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.RPT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.RPT
{
    [Route("api/RPT/[controller]")]
    [ApiController]
    public class ReportParamContentController : ControllerBase
    {
        readonly IRPT_ReportParamContentService<RPT_ReportParamContent,SqlResult> rPT_ReportParamContentService;

        public ReportParamContentController(IRPT_ReportParamContentService<RPT_ReportParamContent, SqlResult> _rPT_ReportParamContentService)
        {
            rPT_ReportParamContentService = _rPT_ReportParamContentService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "RPT,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = rPT_ReportParamContentService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
