using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_EmployeeForSmsManager : ISYS_tbl_EmployeeForSmsService<SYS_tbl_EmployeeForSms, SqlResult>
    {
        private readonly ISYS_tbl_EmployeeForSmsDal _sys_tbl_EmployeeForSmsDal;

        public SYS_tbl_EmployeeForSmsManager(ISYS_tbl_EmployeeForSmsDal sys_tbl_EmployeeForSmsDal)
        {
            _sys_tbl_EmployeeForSmsDal = sys_tbl_EmployeeForSmsDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_EmployeeForSms>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_EmployeeForSms>>(_sys_tbl_EmployeeForSmsDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_EmployeeForSmsDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
