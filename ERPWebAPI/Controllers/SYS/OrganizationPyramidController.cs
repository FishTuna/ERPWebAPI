using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.SYS
{
    [Route("api/SYS/[controller]")]
    [ApiController]
    public class OrganizationPyramidController : ControllerBase
    {
        readonly ISYS_OrganizationPyramidService<SYS_OrganizationPyramid, SqlResult> _organizationPyramidService;


        public OrganizationPyramidController(ISYS_OrganizationPyramidService<SYS_OrganizationPyramid, SqlResult> organizationPyramidservice)
        {
            _organizationPyramidService = organizationPyramidservice;

        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _organizationPyramidService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
