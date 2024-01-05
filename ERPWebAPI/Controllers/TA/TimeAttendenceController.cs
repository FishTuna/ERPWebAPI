using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.TA;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.TA
{
    [Route("api/TA/[controller]")]
    [ApiController]
    public class TimeAttendenceController : ControllerBase
    {
        readonly ITA_TimeAttendenceService<TA_TimeAttendence, SqlResult> _timeAttendenceService;

        public TimeAttendenceController(ITA_TimeAttendenceService<TA_TimeAttendence, SqlResult> TimeAttendenceService)
        {

            _timeAttendenceService = TimeAttendenceService;

        }
        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "TA,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _timeAttendenceService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpDelete("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "TA,Admin")]
        public IActionResult Delete([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _timeAttendenceService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "TA,Admin")]
        public IActionResult Insert([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _timeAttendenceService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPut("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "TA,Admin")]
        public IActionResult Update([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _timeAttendenceService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
