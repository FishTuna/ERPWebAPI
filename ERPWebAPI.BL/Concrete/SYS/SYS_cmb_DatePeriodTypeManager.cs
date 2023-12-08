

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_DatePeriodTypeManager : ISYS_cmb_DatePeriodTypeService<SYS_cmb_DatePeriodType, SqlResult>
    {
        private readonly ISYS_cmb_DatePeriodTypeDal _sys_cmb_datePeriodTypeDal;

        public SYS_cmb_DatePeriodTypeManager(ISYS_cmb_DatePeriodTypeDal sys_cmb_DatePeriodTypeDal)
        {
            _sys_cmb_datePeriodTypeDal = sys_cmb_DatePeriodTypeDal;
        }

        //[CacheAspect]
        public IDataResult<List<SYS_cmb_DatePeriodType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_DatePeriodType>>(_sys_cmb_datePeriodTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_datePeriodTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
