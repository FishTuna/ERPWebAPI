
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.TA;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.TA;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.TA;

namespace ERPWebAPI.BL.Concrete.TA
{
    public class TA_WorkPlaceTypeManager : ITA_WorkPlaceTypeService<TA_WorkPlaceType, SqlResult>
    {
        ITA_WorkPlaceTypeDal _tA_WorkPlaceTypeDal;

        public TA_WorkPlaceTypeManager(ITA_WorkPlaceTypeDal tA_WorkPlaceTypeDal)
        {
            _tA_WorkPlaceTypeDal = tA_WorkPlaceTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<TA_WorkPlaceType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<TA_WorkPlaceType>>(_tA_WorkPlaceTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tA_WorkPlaceTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
