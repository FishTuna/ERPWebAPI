

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_LeaveEarningTypeManager : IHR_cmb_LeaveEarningTypeService<HR_cmb_LeaveEarningType, SqlResult>
    {
        IHR_cmb_LeaveEarningTypeDal _hR_cmb_LeaveEarningTypeDal;

        public HR_cmb_LeaveEarningTypeManager(IHR_cmb_LeaveEarningTypeDal hR_cmb_LeaveEarningTypeDal)
        {
            _hR_cmb_LeaveEarningTypeDal = hR_cmb_LeaveEarningTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_LeaveEarningType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_LeaveEarningType>>(_hR_cmb_LeaveEarningTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_LeaveEarningTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
