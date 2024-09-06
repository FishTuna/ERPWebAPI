

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TorkOccurrenceConsequenceManager : IOHS_TorkOccurrenceConsequenceService<OHS_TorkOccurrenceConsequence, SqlResult>
    {
        IOHS_TorkOccurrenceConsequenceDal _oHS_TorkOccurrenceConsequenceDal;

        public OHS_TorkOccurrenceConsequenceManager(IOHS_TorkOccurrenceConsequenceDal oHS_TorkOccurrenceConsequenceDal)
        {
            _oHS_TorkOccurrenceConsequenceDal = oHS_TorkOccurrenceConsequenceDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TorkOccurrenceConsequence>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TorkOccurrenceConsequence>>(_oHS_TorkOccurrenceConsequenceDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TorkOccurrenceConsequenceDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
