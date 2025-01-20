
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TrainingSessionAbsentManager : IOHS_TrainingSessionAbsentService<OHS_TrainingSessionAbsent, SqlResult>
    {
        IOHS_TrainingSessionAbsentDal _oHS_TrainingSessionAbsentDal;

        public OHS_TrainingSessionAbsentManager(IOHS_TrainingSessionAbsentDal oHS_TrainingSessionAbsentDal)
        {
            _oHS_TrainingSessionAbsentDal = oHS_TrainingSessionAbsentDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TrainingSessionAbsent>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TrainingSessionAbsent>>(_oHS_TrainingSessionAbsentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TrainingSessionAbsentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
