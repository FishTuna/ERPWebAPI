

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_CmbTableManager : ISYS_cmb_CmbTableService<SYS_cmb_CmbTable, SqlResult>
    {
        private readonly ISYS_cmb_CmbTableDal _sYS_cmb_CmbTable;

        public SYS_cmb_CmbTableManager(ISYS_cmb_CmbTableDal sYS_cmb_CmbTable)
        {
            _sYS_cmb_CmbTable = sYS_cmb_CmbTable;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_CmbTable>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_CmbTable>>(_sYS_cmb_CmbTable.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_cmb_CmbTable.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
