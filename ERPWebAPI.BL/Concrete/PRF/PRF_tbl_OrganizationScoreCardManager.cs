

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_OrganizationScoreCardManager : IPRF_tbl_OrganizationScoreCardService<PRF_tbl_OrganizationScoreCard, SqlResult>
    {
        private readonly IPRF_tbl_OrganizationScoreCardDal _pRF_tbl_OrganizationScoreCardDal;

        public PRF_tbl_OrganizationScoreCardManager(IPRF_tbl_OrganizationScoreCardDal pRF_tbl_OrganizationScoreCardDal)
        {
            _pRF_tbl_OrganizationScoreCardDal = pRF_tbl_OrganizationScoreCardDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_OrganizationScoreCard>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_OrganizationScoreCard>>(_pRF_tbl_OrganizationScoreCardDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_OrganizationScoreCardDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
