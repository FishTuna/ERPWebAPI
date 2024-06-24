

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TorkIncidenceRealizationManager : IOHS_TorkIncidenceRealizationService<OHS_TorkIncidenceRealization, SqlResult>
    {
        IOHS_TorkIncidenceRealizationDal _oHS_TorkIncidenceRealizationDal;

        public OHS_TorkIncidenceRealizationManager(IOHS_TorkIncidenceRealizationDal oHS_TorkIncidenceRealizationDal)
        {
            _oHS_TorkIncidenceRealizationDal = oHS_TorkIncidenceRealizationDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TorkIncidenceRealization>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TorkIncidenceRealization>>(_oHS_TorkIncidenceRealizationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TorkIncidenceRealizationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
