using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.TA;

namespace ERPWebAPI.BL.Concrete.TA
{
    public class TA_EmployeeListManager : ITA_EmployeeListService<TA_EmployeeList, SqlResult>
    {
        ITA_EmployeeListDal _tA_EmployeeListDal;

        public TA_EmployeeListManager(ITA_EmployeeListDal tA_EmployeeListDal)
        {
            _tA_EmployeeListDal = tA_EmployeeListDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<TA_EmployeeList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<TA_EmployeeList>>(_tA_EmployeeListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tA_EmployeeListDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
