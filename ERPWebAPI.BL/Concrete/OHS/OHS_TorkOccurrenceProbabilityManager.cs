

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TorkOccurrenceProbabilityManager : IOHS_TorkOccurrenceProbabilityService<OHS_TorkOccurrenceProbability, SqlResult>
    {
        IOHS_TorkOccurrenceProbabilityDal _oHS_TorkOccurrenceProbabilityDal;

        public OHS_TorkOccurrenceProbabilityManager(IOHS_TorkOccurrenceProbabilityDal oHS_TorkOccurrenceProbabilityDal)
        {
            _oHS_TorkOccurrenceProbabilityDal = oHS_TorkOccurrenceProbabilityDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TorkOccurrenceProbability>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TorkOccurrenceProbability>>(_oHS_TorkOccurrenceProbabilityDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TorkOccurrenceProbabilityDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
