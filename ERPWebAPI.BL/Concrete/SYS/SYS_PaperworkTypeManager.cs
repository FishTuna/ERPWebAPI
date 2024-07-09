using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_PaperworkTypeManager : ISYS_PaperworkTypeService<SYS_PaperworkType, SqlResult>
    {
        ISYS_PaperworkTypeDal _sYS_PaperworkTypeDal;

        public SYS_PaperworkTypeManager(ISYS_PaperworkTypeDal sYS_PaperworkTypeDal)
        {
            _sYS_PaperworkTypeDal = sYS_PaperworkTypeDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<SYS_PaperworkType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_PaperworkType>>(_sYS_PaperworkTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_PaperworkTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
