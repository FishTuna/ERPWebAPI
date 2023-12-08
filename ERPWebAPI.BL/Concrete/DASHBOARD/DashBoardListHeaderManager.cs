using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.DASHBOARD;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.DASHBOARD;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;


namespace ERPWebAPI.BL.Concrete.DASHBOARD
{
    public class DashBoardListHeaderManager : IDashBoardListHeaderService<DashBoardListHeader, SqlResult>
    {
        private readonly IDashBoardListHeaderDal _dashBoardListHeader;

        public DashBoardListHeaderManager(IDashBoardListHeaderDal dashBoardListHeader)
        {
            _dashBoardListHeader = dashBoardListHeader;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<DashBoardListHeader>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<DashBoardListHeader>>(_dashBoardListHeader.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _dashBoardListHeader.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
