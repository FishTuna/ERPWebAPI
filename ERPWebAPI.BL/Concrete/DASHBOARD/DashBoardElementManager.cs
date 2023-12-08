using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.DASHBOARD;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.DASHBOARD;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.DASHBOARD;


namespace ERPWebAPI.BL.Concrete.DASHBOARD
{
    public class DashBoardElementManager : IDashBoardElementService<DashBoardElement, SqlResult>
    {
        private readonly IDashBoardElementDal _dashBoardElement;

        public DashBoardElementManager(IDashBoardElementDal dashBoardElement)
        {
            _dashBoardElement = dashBoardElement;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<DashBoardElement>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<DashBoardElement>>(_dashBoardElement.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _dashBoardElement.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
