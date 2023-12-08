using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.DASHBOARD;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.DASHBOARD;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;


namespace ERPWebAPI.BL.Concrete.DASHBOARD
{
    public class DashBoardListDetailManager : IDashBoardListDetailService<DashBoardListDetail, SqlResult>
    {
        private readonly IDashBoardListDetailDal _dashBoardListDetail;

        public DashBoardListDetailManager(IDashBoardListDetailDal dashBoardListDetail)
        {
            _dashBoardListDetail = dashBoardListDetail;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<DashBoardListDetail>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<DashBoardListDetail>>(_dashBoardListDetail.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _dashBoardListDetail.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
