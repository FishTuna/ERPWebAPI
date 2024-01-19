

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_EmployeeLeaveEarningTypeHistoryManager : IHR_tbl_EmployeeLeaveEarningTypeHistoryService<HR_tbl_EmployeeLeaveEarningTypeHistory, SqlResult>
    {
        IHR_tbl_EmployeeLeaveEarningTypeHistoryDal _hR_tbl_EmployeeLeaveEarningTypeHistoryDal;

        public HR_tbl_EmployeeLeaveEarningTypeHistoryManager(IHR_tbl_EmployeeLeaveEarningTypeHistoryDal hR_tbl_EmployeeLeaveEarningTypeHistoryDal)
        {
            _hR_tbl_EmployeeLeaveEarningTypeHistoryDal = hR_tbl_EmployeeLeaveEarningTypeHistoryDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_EmployeeLeaveEarningTypeHistory>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_EmployeeLeaveEarningTypeHistory>>(_hR_tbl_EmployeeLeaveEarningTypeHistoryDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_EmployeeLeaveEarningTypeHistoryDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
