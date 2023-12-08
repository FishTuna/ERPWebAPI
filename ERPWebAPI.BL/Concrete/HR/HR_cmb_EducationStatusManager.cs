using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_EducationStatusManager : IHR_cmb_EducationStatusService<HR_cmb_EducationStatu, SqlResult>
    {
        IHR_cmb_EducationStatusDal _hR_cmb_EducationStatuDal;
        public HR_cmb_EducationStatusManager(IHR_cmb_EducationStatusDal hR_cmb_EducationStatuDal)
        {
            _hR_cmb_EducationStatuDal = hR_cmb_EducationStatuDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(EducationStatuValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_EducationStatu>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_EducationStatu>>(_hR_cmb_EducationStatuDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_EducationStatuDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
