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
    public class MistakeAdmireGroupController : ControllerBase
    {
        readonly IHR_cmb_MistakeAdmireGroupService<HR_cmb_MistakeAdmireGroup, SqlResult> _cmb_MistakeAdmireGroupService;

        public MistakeAdmireGroupController(IHR_cmb_MistakeAdmireGroupService<HR_cmb_MistakeAdmireGroup, SqlResult> cmb_MistakeAdmireGroupService)
        {
            _cmb_MistakeAdmireGroupService = cmb_MistakeAdmireGroupService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "HR,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _cmb_MistakeAdmireGroupService.GetAllDataMngr(module, target, point, parameters);
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
            var result = _cmb_MistakeAdmireGroupService.ResultOperationsMngr(module, target, point, parameters);
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
            var result = _cmb_MistakeAdmireGroupService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}

