

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_cmb_AnswerRatingManager : IPRF_cmb_AnswerRatingService<PRF_cmb_AnswerRating, SqlResult>
    {
        private readonly IPRF_cmb_AnswerRatingDal _pRF_cmb_AnswerRatingDal;

        public PRF_cmb_AnswerRatingManager(IPRF_cmb_AnswerRatingDal pRF_cmb_AnswerRatingDal)
        {
            _pRF_cmb_AnswerRatingDal = pRF_cmb_AnswerRatingDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_cmb_AnswerRating>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_cmb_AnswerRating>>(_pRF_cmb_AnswerRatingDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_cmb_AnswerRatingDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
