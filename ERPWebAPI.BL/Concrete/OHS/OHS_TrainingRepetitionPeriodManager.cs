
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TrainingRepetitionPeriodManager : IOHS_TrainingRepetitionPeriodService<OHS_TrainingRepetitionPeriod, SqlResult>
    {
        IOHS_TrainingRepetitionPeriodDal _oHS_TrainingRepetitionPeriodDal;

        public OHS_TrainingRepetitionPeriodManager(IOHS_TrainingRepetitionPeriodDal oHS_TrainingRepetitionPeriodDal)
        {
            _oHS_TrainingRepetitionPeriodDal = oHS_TrainingRepetitionPeriodDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TrainingRepetitionPeriod>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TrainingRepetitionPeriod>>(_oHS_TrainingRepetitionPeriodDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TrainingRepetitionPeriodDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
