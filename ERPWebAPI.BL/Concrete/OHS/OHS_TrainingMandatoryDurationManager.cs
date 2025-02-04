
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TrainingMandatoryDurationManager : IOHS_TrainingMandatoryDurationService<OHS_TrainingMandatoryDuration, SqlResult>
    {
        IOHS_TrainingMandatoryDurationDal _oHS_TrainingMandatoryDurationDal;

        public OHS_TrainingMandatoryDurationManager(IOHS_TrainingMandatoryDurationDal oHS_TrainingMandatoryDurationDal)
        {
            _oHS_TrainingMandatoryDurationDal = oHS_TrainingMandatoryDurationDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TrainingMandatoryDuration>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TrainingMandatoryDuration>>(_oHS_TrainingMandatoryDurationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TrainingMandatoryDurationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
