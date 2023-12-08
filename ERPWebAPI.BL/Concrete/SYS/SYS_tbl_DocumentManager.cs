
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_DocumentManager : ISYS_tbl_DocumentService<SYS_tbl_Document, SqlResult>
    {
        private readonly ISYS_tbl_DocumentDal _sys_tbl_documentDal;

        public SYS_tbl_DocumentManager(ISYS_tbl_DocumentDal sys_tbl_DocumentDal)
        {
            _sys_tbl_documentDal = sys_tbl_DocumentDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_Document>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_Document>>(_sys_tbl_documentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_documentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
