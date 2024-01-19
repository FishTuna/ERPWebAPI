using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_sp_AnnualLeaveDetailManager : IHR_sp_AnnualLeaveDetailService<HR_sp_AnnualLeaveDetail, SqlResult>
    {
        IHR_sp_AnnualLeaveDetailDal _hR_sp_AnnualLeaveDetailDal;

        public HR_sp_AnnualLeaveDetailManager(IHR_sp_AnnualLeaveDetailDal hR_sp_AnnualLeaveDetailDal)
        {
            _hR_sp_AnnualLeaveDetailDal = hR_sp_AnnualLeaveDetailDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(PositionValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_sp_AnnualLeaveDetail>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_sp_AnnualLeaveDetail>>(_hR_sp_AnnualLeaveDetailDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }
        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_sp_AnnualLeaveDetailDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
