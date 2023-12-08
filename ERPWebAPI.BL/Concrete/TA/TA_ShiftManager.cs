

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.EL.Concrete.TA;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.TA
{
    public class TA_ShiftManager : ITA_ShiftService<TA_Shift, SqlResult>
    {
        ITA_ShiftDal _tA_ShiftDal;

        public TA_ShiftManager(ITA_ShiftDal tA_ShiftDal)
        {
            _tA_ShiftDal = tA_ShiftDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<TA_Shift>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<TA_Shift>>(_tA_ShiftDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tA_ShiftDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
