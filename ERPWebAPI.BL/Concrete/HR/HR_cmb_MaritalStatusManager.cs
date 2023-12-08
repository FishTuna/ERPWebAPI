using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_MaritalStatusManager : IHR_cmb_MaritalStatusService<HR_cmb_MaritalStatu, SqlResult>
    {
        IHR_cmb_MaritalStatusDal _hR_cmb_MaritalStatuDal;

        public HR_cmb_MaritalStatusManager(IHR_cmb_MaritalStatusDal hR_cmb_MaritalStatuDal)
        {
            _hR_cmb_MaritalStatuDal = hR_cmb_MaritalStatuDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(MaritalStatuValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_MaritalStatu>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_MaritalStatu>>(_hR_cmb_MaritalStatuDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_MaritalStatuDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
