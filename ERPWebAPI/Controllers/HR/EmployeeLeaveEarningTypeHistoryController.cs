using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.HR
{
    [Route("api/HR/[controller]")]
    [ApiController]
    public class EmployeeLeaveEarningTypeHistoryController : ControllerBase
    {
        readonly IHR_tbl_EmployeeLeaveEarningTypeHistoryService<HR_tbl_EmployeeLeaveEarningTypeHistory, SqlResult> _hR_tbl_EmployeeLeaveEarningTypeHistoryService;

        public EmployeeLeaveEarningTypeHistoryController(IHR_tbl_EmployeeLeaveEarningTypeHistoryService<HR_tbl_EmployeeLeaveEarningTypeHistory, SqlResult> hR_tbl_EmployeeLeaveEarningTypeHistoryService)
        {
            _hR_tbl_EmployeeLeaveEarningTypeHistoryService = hR_tbl_EmployeeLeaveEarningTypeHistoryService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "HR,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _hR_tbl_EmployeeLeaveEarningTypeHistoryService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "HR,Admin")]
        public IActionResult Insert([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _hR_tbl_EmployeeLeaveEarningTypeHistoryService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPut("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "HR,Admin")]
        public IActionResult Update([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _hR_tbl_EmployeeLeaveEarningTypeHistoryService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
