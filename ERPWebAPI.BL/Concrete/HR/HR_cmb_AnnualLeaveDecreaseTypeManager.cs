
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_AnnualLeaveDecreaseTypeManager : IHR_cmb_AnnualLeaveDecreaseTypeService<HR_cmb_AnnualLeaveDecreaseType, SqlResult>
    {
        IHR_cmb_AnnualLeaveDecreaseTypeDal _hR_cmb_AnnualLeaveDecreaseTypeDal;

        public HR_cmb_AnnualLeaveDecreaseTypeManager(IHR_cmb_AnnualLeaveDecreaseTypeDal hR_cmb_AnnualLeaveDecreaseTypeDal)
        {
            _hR_cmb_AnnualLeaveDecreaseTypeDal = hR_cmb_AnnualLeaveDecreaseTypeDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(JobValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_AnnualLeaveDecreaseType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_AnnualLeaveDecreaseType>>(_hR_cmb_AnnualLeaveDecreaseTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_AnnualLeaveDecreaseTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
