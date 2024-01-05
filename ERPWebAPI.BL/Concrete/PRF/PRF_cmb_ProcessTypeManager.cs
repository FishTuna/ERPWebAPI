

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_cmb_ProcessTypeManager : IPRF_cmb_ProcessTypeService<PRF_cmb_ProcessType, SqlResult>
    {
        private readonly IPRF_cmb_ProcessTypeDal _pRF_cmb_ProcessTypeDal;

        public PRF_cmb_ProcessTypeManager(IPRF_cmb_ProcessTypeDal pRF_cmb_ProcessTypeDal)
        {
            _pRF_cmb_ProcessTypeDal = pRF_cmb_ProcessTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_cmb_ProcessType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_cmb_ProcessType>>(_pRF_cmb_ProcessTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_cmb_ProcessTypeDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
