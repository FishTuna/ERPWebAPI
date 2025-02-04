

using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_IndustryManager : IOHS_IndustryService<OHS_Industry, SqlResult>
    {
        IOHS_IndustryDal _oHS_IndustryDal;

        public OHS_IndustryManager(IOHS_IndustryDal oHS_IndustryDal)
        {
            _oHS_IndustryDal = oHS_IndustryDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_Industry>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_Industry>>(_oHS_IndustryDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_IndustryDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
