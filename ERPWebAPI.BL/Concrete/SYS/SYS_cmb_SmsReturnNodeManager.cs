using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_SmsReturnNodeManager : ISYS_cmb_SmsReturnNodeService<SYS_cmb_SmsReturnNode, SqlResult>
    {
        private readonly ISYS_cmb_SmsReturnNodeDal _sys_cmb_SmsReturnNodeDal;

        public SYS_cmb_SmsReturnNodeManager(ISYS_cmb_SmsReturnNodeDal sys_cmb_SmsReturnNodeDal)
        {
            _sys_cmb_SmsReturnNodeDal = sys_cmb_SmsReturnNodeDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_SmsReturnNode>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_SmsReturnNode>>(_sys_cmb_SmsReturnNodeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_SmsReturnNodeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
