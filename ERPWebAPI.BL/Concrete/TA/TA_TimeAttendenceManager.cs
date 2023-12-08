

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.EL.Concrete.TA;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.TA
{
    public class TA_TimeAttendenceManager : ITA_TimeAttendenceService<TA_TimeAttendence, SqlResult>
    {
        ITA_TimeAttendenceDal _tA_TimeAttendenceDal;

        public TA_TimeAttendenceManager(ITA_TimeAttendenceDal tA_TimeAttendenceDal)
        {
            _tA_TimeAttendenceDal = tA_TimeAttendenceDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<TA_TimeAttendence>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<TA_TimeAttendence>>(_tA_TimeAttendenceDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tA_TimeAttendenceDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
