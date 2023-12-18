

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_cmb_AnswerRatingGroupManager : IPRF_cmb_AnswerRatingGroupService<PRF_cmb_AnswerRatingGroup, SqlResult>
    {
        private readonly IPRF_cmb_AnswerRatingGroupDal _pRF_cmb_AnswerRatingGroupDal;

        public PRF_cmb_AnswerRatingGroupManager(IPRF_cmb_AnswerRatingGroupDal pRF_cmb_AnswerRatingGroupDal)
        {
            _pRF_cmb_AnswerRatingGroupDal = pRF_cmb_AnswerRatingGroupDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_cmb_AnswerRatingGroup>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_cmb_AnswerRatingGroup>>(_pRF_cmb_AnswerRatingGroupDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_cmb_AnswerRatingGroupDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
