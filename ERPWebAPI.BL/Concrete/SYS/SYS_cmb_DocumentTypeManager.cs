

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_DocumentTypeManager : ISYS_cmb_DocumentTypeService<SYS_cmb_DocumentType, SqlResult>
    {
        private readonly ISYS_cmb_DocumentTypeDal _sys_cmb_documentTypeDal;

        public SYS_cmb_DocumentTypeManager(ISYS_cmb_DocumentTypeDal sys_cmb_DocumentTypeDal)
        {
            _sys_cmb_documentTypeDal = sys_cmb_DocumentTypeDal;
        }

        //[CacheAspect]
        public IDataResult<List<SYS_cmb_DocumentType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_DocumentType>>(_sys_cmb_documentTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_documentTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
