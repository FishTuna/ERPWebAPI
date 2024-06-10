
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_ResumeEducationInfoManager : IHR_ResumeEducationInfoService<HR_ResumeEducationInfo, SqlResult>
    {
        IHR_ResumeEducationInfoDal _hR_ResumeEducationInfoDal;

        public HR_ResumeEducationInfoManager(IHR_ResumeEducationInfoDal hR_ResumeEducationInfoDal)
        {
            _hR_ResumeEducationInfoDal = hR_ResumeEducationInfoDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_ResumeEducationInfo>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_ResumeEducationInfo>>(_hR_ResumeEducationInfoDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_ResumeEducationInfoDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
