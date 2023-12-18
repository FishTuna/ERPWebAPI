

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_AnswerManager : IPRF_tbl_AnswerService<PRF_tbl_Answer, SqlResult>
    {
        private readonly IPRF_tbl_AnswerDal _pRF_tbl_AnswerDal;

        public PRF_tbl_AnswerManager(IPRF_tbl_AnswerDal pRF_tbl_AnswerDal)
        {
            _pRF_tbl_AnswerDal = pRF_tbl_AnswerDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_Answer>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_Answer>>(_pRF_tbl_AnswerDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_AnswerDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
