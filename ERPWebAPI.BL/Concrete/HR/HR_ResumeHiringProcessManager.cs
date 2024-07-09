

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_ResumeHiringProcessManager : IHR_ResumeHiringProcessService<HR_ResumeHiringProcess, SqlResult>
    {
        IHR_ResumeHiringProcessDal _hR_ResumeHiringProcessDal;

        public HR_ResumeHiringProcessManager(IHR_ResumeHiringProcessDal hR_ResumeHiringProcessDal)
        {
            _hR_ResumeHiringProcessDal = hR_ResumeHiringProcessDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_ResumeHiringProcess>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_ResumeHiringProcess>>(_hR_ResumeHiringProcessDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_ResumeHiringProcessDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
