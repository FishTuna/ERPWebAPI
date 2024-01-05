using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.PRF
{
    [Route("api/PRF/[controller]")]
    [ApiController]
    public class OrganizationScoreCardController : ControllerBase
    {
        readonly IPRF_tbl_OrganizationScoreCardService<PRF_tbl_OrganizationScoreCard, SqlResult> _tbl_OrganizationScoreCardService;

        public OrganizationScoreCardController(IPRF_tbl_OrganizationScoreCardService<PRF_tbl_OrganizationScoreCard, SqlResult> tbl_OrganizationScoreCardService)
        {
            _tbl_OrganizationScoreCardService = tbl_OrganizationScoreCardService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "PRF,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _tbl_OrganizationScoreCardService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "PRF,Admin")]
        public IActionResult Insert([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _tbl_OrganizationScoreCardService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPut("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "PRF,Admin")]
        public IActionResult Update([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _tbl_OrganizationScoreCardService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpDelete("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "PRF,Admin")]
        public IActionResult Delete([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _tbl_OrganizationScoreCardService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
