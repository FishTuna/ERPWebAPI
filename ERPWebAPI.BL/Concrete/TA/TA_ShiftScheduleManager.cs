

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.EL.Concrete.TA;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.TA
{
    public class TA_ShiftScheduleManager : ITA_ShiftScheduleService<TA_ShiftSchedule, SqlResult>
    {
        ITA_ShiftScheduleDal _tA_ShiftScheduleDal;

        public TA_ShiftScheduleManager(ITA_ShiftScheduleDal tA_ShiftScheduleDal)
        {
            _tA_ShiftScheduleDal = tA_ShiftScheduleDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<TA_ShiftSchedule>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<TA_ShiftSchedule>>(_tA_ShiftScheduleDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tA_ShiftScheduleDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
