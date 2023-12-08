using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_LeaveEarningManager : IHR_tbl_LeaveEarningService<HR_tbl_LeaveEarning, SqlResult>
    {
        IHR_tbl_LeaveEarningDal _hR_tbl_AnnualLeaveEarningDal;

        public HR_tbl_LeaveEarningManager(IHR_tbl_LeaveEarningDal hR_tbl_AnnualLeaveEarningDal)
        {
            _hR_tbl_AnnualLeaveEarningDal = hR_tbl_AnnualLeaveEarningDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_LeaveEarning>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_LeaveEarning>>(_hR_tbl_AnnualLeaveEarningDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_AnnualLeaveEarningDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
