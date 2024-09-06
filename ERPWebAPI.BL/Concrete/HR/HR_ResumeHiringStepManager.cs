

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_ResumeHiringStepManager : IHR_ResumeHiringStepService<HR_ResumeHiringStep, SqlResult>
    {
        IHR_ResumeHiringStepDal _hR_ResumeHiringStepDal;

        public HR_ResumeHiringStepManager(IHR_ResumeHiringStepDal hR_ResumeHiringStepDal)
        {
            _hR_ResumeHiringStepDal = hR_ResumeHiringStepDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_ResumeHiringStep>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_ResumeHiringStep>>(_hR_ResumeHiringStepDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_ResumeHiringStepDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
