

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_YearListManager : ISYS_cmb_YearListService<SYS_cmb_YearList, SqlResult>
    {
        private readonly ISYS_cmb_YearListDal _sYS_cmb_YearListDal;

        public SYS_cmb_YearListManager(ISYS_cmb_YearListDal sYS_cmb_YearListDal)
        {
            _sYS_cmb_YearListDal = sYS_cmb_YearListDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<SYS_cmb_YearList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_YearList>>(_sYS_cmb_YearListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_cmb_YearListDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
