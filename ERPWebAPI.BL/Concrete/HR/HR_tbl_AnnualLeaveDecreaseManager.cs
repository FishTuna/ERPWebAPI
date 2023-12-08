using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.DAL.Concrete.HR
{
    public class HR_tbl_AnnualLeaveDecreaseManager : IHR_tbl_AnnualLeaveDecreaseService<HR_tbl_AnnualLeaveDecrease, SqlResult>
    {
        IHR_tbl_AnnualLeaveDecreaseDal _hR_tbl_AnnualLeaveDecreaseDal;

        public HR_tbl_AnnualLeaveDecreaseManager(IHR_tbl_AnnualLeaveDecreaseDal hR_tbl_AnnualLeaveDecreaseDal)
        {
            _hR_tbl_AnnualLeaveDecreaseDal = hR_tbl_AnnualLeaveDecreaseDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(JobValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_AnnualLeaveDecrease>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_AnnualLeaveDecrease>>(_hR_tbl_AnnualLeaveDecreaseDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_AnnualLeaveDecreaseDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
