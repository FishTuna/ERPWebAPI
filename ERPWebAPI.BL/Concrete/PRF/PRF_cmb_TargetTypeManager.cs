

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete.PRF;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_cmb_TargetTypeManager : IPRF_cmb_TargetTypeService<PRF_cmb_TargetType, SqlResult>
    {
        private readonly IPRF_cmb_TargetTypeDal _pRF_cmb_TargetTypeDal;

        public PRF_cmb_TargetTypeManager(IPRF_cmb_TargetTypeDal pRF_cmb_TargetTypeDal)
        {
            _pRF_cmb_TargetTypeDal = pRF_cmb_TargetTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_cmb_TargetType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_cmb_TargetType>>(_pRF_cmb_TargetTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_cmb_TargetTypeDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
