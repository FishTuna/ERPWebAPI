

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_QuestionGroupMatchManager : IPRF_tbl_QuestionGroupMatchService<PRF_tbl_QuestionGroupMatch, SqlResult>
    {
        private readonly IPRF_tbl_QuestionGroupMatchDal _pRF_tbl_QuestionGroupMatchDal;

        public PRF_tbl_QuestionGroupMatchManager(IPRF_tbl_QuestionGroupMatchDal pRF_tbl_QuestionGroupMatchDal)
        {
            _pRF_tbl_QuestionGroupMatchDal = pRF_tbl_QuestionGroupMatchDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_QuestionGroupMatch>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_QuestionGroupMatch>>(_pRF_tbl_QuestionGroupMatchDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_QuestionGroupMatchDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
