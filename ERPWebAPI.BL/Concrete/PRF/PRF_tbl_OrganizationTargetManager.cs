using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_OrganizationTargetManager : IPRF_tbl_OrganizationTargetService<PRF_tbl_OrganizationTarget, SqlResult>
    {
        private readonly IPRF_tbl_OrganizationTargetDal _pRF_tbl_OrganizationTargetDal;

        public PRF_tbl_OrganizationTargetManager(IPRF_tbl_OrganizationTargetDal pRF_tbl_OrganizationTargetDal)
        {
            _pRF_tbl_OrganizationTargetDal = pRF_tbl_OrganizationTargetDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_OrganizationTarget>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_OrganizationTarget>>(_pRF_tbl_OrganizationTargetDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_OrganizationTargetDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
