using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_MissingDayReasonManager : IHR_cmb_MissingDayReasonService<HR_cmb_MissingDayReason, SqlResult>
    {
        IHR_cmb_MissingDayReasonDal _hR_cmb_MissingDayReasonDal;

        public HR_cmb_MissingDayReasonManager(IHR_cmb_MissingDayReasonDal hR_cmb_MissingDayReasonDal)
        {
            _hR_cmb_MissingDayReasonDal = hR_cmb_MissingDayReasonDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(MissingDayReasonValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_MissingDayReason>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_MissingDayReason>>(_hR_cmb_MissingDayReasonDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_MissingDayReasonDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
