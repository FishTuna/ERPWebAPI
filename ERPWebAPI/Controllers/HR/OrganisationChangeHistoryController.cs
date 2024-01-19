using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.HR
{
    [Route("api/HR/[controller]")]
    [ApiController]
    public class OrganisationChangeHistoryController : ControllerBase
    {
        readonly IHR_tbl_OrganisationChangeHistoryService<HR_tbl_OrganisationChangeHistory, SqlResult> _tbl_OrganisationChangeHistoryService;

        public OrganisationChangeHistoryController(IHR_tbl_OrganisationChangeHistoryService<HR_tbl_OrganisationChangeHistory, SqlResult> tbl_OrganisationChangeHistoryService)
        {
            _tbl_OrganisationChangeHistoryService = tbl_OrganisationChangeHistoryService;
        }


        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "HR,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _tbl_OrganisationChangeHistoryService.GetAllDataMngr(module, target, point, parameters);
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
            var result = _tbl_OrganisationChangeHistoryService.ResultOperationsMngr(module, target, point, parameters);
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
            var result = _tbl_OrganisationChangeHistoryService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
