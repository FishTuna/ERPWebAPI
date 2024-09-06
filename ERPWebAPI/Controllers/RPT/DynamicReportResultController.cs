using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ERPWebAPI.BL.Abstract.RPT;

namespace ERPWebAPI.Controllers.RPT
{
    [Route("api/RPT/[controller]")]
    [ApiController]
    public class DynamicReportResultController : ControllerBase
    {
        readonly IRPT_DynamicReportResultService rPT_DynamicReportResultService;

        public DynamicReportResultController(IRPT_DynamicReportResultService _rPT_DynamicReportResultService)
        {
            rPT_DynamicReportResultService = _rPT_DynamicReportResultService;
        }

        [HttpGet("{module}/{target}/{parameters}")]
        //[Authorize(Roles = "DataReader,Admin")]
        //[Authorize(Roles = "PRF,Admin")]
        [AllowAnonymous]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target,[FromRoute] string parameters)
        {
            var result = rPT_DynamicReportResultService.GetDynamicReportResultMng(module, target, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
