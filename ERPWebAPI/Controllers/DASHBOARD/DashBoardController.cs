using ERPWebAPI.BL.Abstract.DASHBOARD;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ERPWebAPI.Controllers.DASHBOARD
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private readonly IDashBoardElementService<DashBoardElement, SqlResult> _dashBoardElementService;
        private readonly IDashBoardListHeaderService<DashBoardListHeader, SqlResult> _dashBoardListHeaderService;
        private readonly IDashBoardListDetailService<DashBoardListDetail, SqlResult> _dashBoardListDetailService;


        public DashBoardController(
                                    IDashBoardElementService<DashBoardElement, SqlResult> dashBoardElementService,
                                    IDashBoardListHeaderService<DashBoardListHeader, SqlResult> dashBoardListHeaderService,
                                    IDashBoardListDetailService<DashBoardListDetail, SqlResult> dashBoardListDetailService
                                  )
        {
            _dashBoardElementService = dashBoardElementService;
            _dashBoardListHeaderService = dashBoardListHeaderService;
            _dashBoardListDetailService = dashBoardListDetailService;
        }

        [HttpGet("[action]/{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult GetElements([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _dashBoardElementService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);

        }

        [HttpGet("[action]/{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult GetListHeaders([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _dashBoardListHeaderService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpGet("[action]/{module}/{target}/{point}/{parameters}")]
        [Authorize(Roles = "DataReader,Admin")]
        [Authorize(Roles = "SYS,Admin")]
        public IActionResult GetListDetails([FromRoute] string module, [FromRoute] string target, [FromRoute] string point, [FromRoute] string parameters)
        {
            var result = _dashBoardListDetailService.GetAllDataMngr(module, target, point, parameters);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
    }
}
