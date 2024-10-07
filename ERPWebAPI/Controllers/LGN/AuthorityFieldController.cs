using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.LGN
{
    [Route("api/LGN/[controller]")]
    [ApiController]
    public class AuthorityFieldController : ControllerBase
    {
        readonly ILGN_AuthorityFieldService<LGN_tbl_Authority_Field, SqlResult> _authfieldService;


        public AuthorityFieldController(ILGN_AuthorityFieldService<LGN_tbl_Authority_Field, SqlResult> authfieldService)
        {

            _authfieldService = authfieldService;

        }
        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "LGN,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _authfieldService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPut("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "LGN,Admin")]
        public IActionResult Update([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _authfieldService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "LGN,Admin")]
        public IActionResult Insert([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _authfieldService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpDelete("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataWriter,Admin")]
        [Authorize(Roles = "LGN,Admin")]
        public IActionResult Delete([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _authfieldService.ResultOperationsMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
