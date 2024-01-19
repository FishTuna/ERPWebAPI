using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_PeriodMatchManager : IPRF_tbl_PeriodMatchService<PRF_tbl_PeriodMatch, SqlResult>
    {
        private readonly IPRF_tbl_PeriodMatchDal _pRF_tbl_PeriodMatchDal;

        public PRF_tbl_PeriodMatchManager(IPRF_tbl_PeriodMatchDal pRF_tbl_PeriodMatchDal)
        {
            _pRF_tbl_PeriodMatchDal = pRF_tbl_PeriodMatchDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_PeriodMatch>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_PeriodMatch>>(_pRF_tbl_PeriodMatchDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_PeriodMatchDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
