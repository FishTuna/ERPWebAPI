

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_ClassificationTypeManager : ISYS_cmb_ClassificationTypeService<SYS_cmb_ClassificationType, SqlResult>
    {
        private readonly ISYS_cmb_ClassificationTypeDal _sys_cmb_classificationTypeDal;

        public SYS_cmb_ClassificationTypeManager(ISYS_cmb_ClassificationTypeDal sys_cmb_ClassificationTypeDal)
        {
            _sys_cmb_classificationTypeDal = sys_cmb_ClassificationTypeDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_ClassificationType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_ClassificationType>>(_sys_cmb_classificationTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_classificationTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
