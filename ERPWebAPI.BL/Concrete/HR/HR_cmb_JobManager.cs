using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_JobManager : IHR_cmb_JobService<HR_cmb_Job, SqlResult>
    {
        IHR_cmb_JobDal _hR_cmb_JobDal;

        public HR_cmb_JobManager(IHR_cmb_JobDal hR_cmb_JobDal)
        {
            _hR_cmb_JobDal = hR_cmb_JobDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(JobValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_Job>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_Job>>(_hR_cmb_JobDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_JobDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
