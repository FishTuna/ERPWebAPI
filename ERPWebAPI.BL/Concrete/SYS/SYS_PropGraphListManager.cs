

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_PropGraphListManager : ISYS_PropGraphListService<SYS_PropGraphList, SqlResult>
    {
        ISYS_PropGraphListDal _sYS_PropGraphListDal;

        public SYS_PropGraphListManager(ISYS_PropGraphListDal sYS_PropGraphListDal)
        {
            _sYS_PropGraphListDal = sYS_PropGraphListDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<SYS_PropGraphList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_PropGraphList>>(_sYS_PropGraphListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_PropGraphListDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
