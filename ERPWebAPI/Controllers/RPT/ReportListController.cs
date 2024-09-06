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
    public class ReportListController : ControllerBase
    {
        readonly IRPT_ReportListService<RPT_ReportList, SqlResult> rPT_ReportListService;

        public ReportListController(IRPT_ReportListService<RPT_ReportList, SqlResult> _rPT_ReportListService)
        {
            rPT_ReportListService = _rPT_ReportListService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,DataWriter,Admin")]
        [Authorize(Roles = "RPT,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = rPT_ReportListService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
