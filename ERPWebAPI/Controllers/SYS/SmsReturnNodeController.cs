using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.SYS
{
    [Route("api/SYS/[controller]")]
    [ApiController]
    public class SmsReturnNodeController : ControllerBase
    {
		readonly ISYS_cmb_SmsReturnNodeService<SYS_cmb_SmsReturnNode, SqlResult> _smsReturnNodeService;


		public SmsReturnNodeController(ISYS_cmb_SmsReturnNodeService<SYS_cmb_SmsReturnNode, SqlResult> smsReturnNodeService)
		{

			_smsReturnNodeService = smsReturnNodeService;

		}
		[HttpGet("{module}/{target}/{point}/{parameters}")]
		[Authorize(Roles = "DataReader,Admin")]
		[Authorize(Roles = "SYS,Admin")]
		public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
		{
			var result = _smsReturnNodeService.GetAllDataMngr(module, target, point, parameters);
			if (result.IsSuccess)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Data);
		}


		[HttpDelete("{module}/{target}/{point}/{parameters}")]
		[Authorize(Roles = "DataWriter,Admin")]
		[Authorize(Roles = "SYS,Admin")]
		public IActionResult Delete([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
		{
			var result = _smsReturnNodeService.ResultOperationsMngr(module, target, point, parameters);
			if (result.IsSuccess)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Data);
		}

		[HttpPost("{module}/{target}/{point}/{parameters}")]
		[Authorize(Roles = "DataWriter,Admin")]
		[Authorize(Roles = "SYS,Admin")]
		public IActionResult Insert([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
		{
			var result = _smsReturnNodeService.ResultOperationsMngr(module, target, point, parameters);
			if (result.IsSuccess)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Data);
		}

		[HttpPut("{module}/{target}/{point}/{parameters}")]
		[Authorize(Roles = "DataWriter,Admin")]
		[Authorize(Roles = "SYS,Admin")]
		public IActionResult Update([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
		{
			var result = _smsReturnNodeService.ResultOperationsMngr(module, target, point, parameters);
			if (result.IsSuccess)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Data);
		}
	}
}
