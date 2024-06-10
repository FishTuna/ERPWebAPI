using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_SendedSmsListManager : ISYS_tbl_SendedSmsListService<SYS_tbl_SendedSmsList, SqlResult>
    {
        private readonly ISYS_tbl_SendedSmsListDal _sys_tbl_SendedSmsListDal;

        public SYS_tbl_SendedSmsListManager(ISYS_tbl_SendedSmsListDal sys_tbl_SendedSmsListDal)
        {
            _sys_tbl_SendedSmsListDal = sys_tbl_SendedSmsListDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_SendedSmsList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_SendedSmsList>>(_sys_tbl_SendedSmsListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_SendedSmsListDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
