


using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_ResumeInterviewManager : IHR_ResumeInterviewService<HR_ResumeInterview, SqlResult>
    {
        IHR_ResumeInterviewDal _hR_ResumeInterviewDal;

        public HR_ResumeInterviewManager(IHR_ResumeInterviewDal hR_ResumeInterviewDal)
        {
            _hR_ResumeInterviewDal = hR_ResumeInterviewDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_ResumeInterview>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_ResumeInterview>>(_hR_ResumeInterviewDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_ResumeInterviewDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
