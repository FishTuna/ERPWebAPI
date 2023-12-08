using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_CostCenterManager : IHR_cmb_CostCenterService<HR_cmb_CostCenter, SqlResult>
    {
        IHR_cmb_CostCenterDal _hR_cmb_CostCenterDal;
        public HR_cmb_CostCenterManager(IHR_cmb_CostCenterDal hR_cmb_CostCenterDal)
        {
            _hR_cmb_CostCenterDal = hR_cmb_CostCenterDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(CostCenterValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_CostCenter>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_CostCenter>>(_hR_cmb_CostCenterDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_CostCenterDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
