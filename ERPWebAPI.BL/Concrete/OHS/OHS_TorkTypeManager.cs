

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TorkTypeManager : IOHS_TorkTypeService<OHS_TorkType, SqlResult>
    {
        IOHS_TorkTypeDal _oHS_TorkTypeDal;

        public OHS_TorkTypeManager(IOHS_TorkTypeDal oHS_TorkTypeDal)
        {
            _oHS_TorkTypeDal = oHS_TorkTypeDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TorkType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TorkType>>(_oHS_TorkTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TorkTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
