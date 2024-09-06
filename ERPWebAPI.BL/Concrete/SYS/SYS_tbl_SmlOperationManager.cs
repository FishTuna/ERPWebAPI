using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_SmlOperationManager : ISYS_tbl_SmlOperationService<SYS_tbl_SmlOperation, SqlResult>
    {
        private readonly ISYS_tbl_SmlOperationDal _sys_tbl_SmlOperationDal;

        public SYS_tbl_SmlOperationManager(ISYS_tbl_SmlOperationDal sys_tbl_SmlOperationDal)
        {
            _sys_tbl_SmlOperationDal = sys_tbl_SmlOperationDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_SmlOperation>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_SmlOperation>>(_sys_tbl_SmlOperationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_SmlOperationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
