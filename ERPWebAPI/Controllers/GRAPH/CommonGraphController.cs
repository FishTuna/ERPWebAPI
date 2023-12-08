using ERPWebAPI.BL.Abstract.GRAPH;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.GRAPHS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERPWebAPI.Controllers.GRAPH
{
    [Route("api/GRAPH/[controller]")]
    [ApiController]
    public class CommonGraphController : ControllerBase
    {
        private readonly ICommonGraphService<CommonGraph, SqlResult> _CommonGraphService;

        public CommonGraphController(ICommonGraphService<CommonGraph, SqlResult> CommonGraphService)
        {
            _CommonGraphService = CommonGraphService;
        }

        [HttpGet("{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult GetAll([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _CommonGraphService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
