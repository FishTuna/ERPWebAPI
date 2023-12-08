

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_UserPrivacyClassificationManager : ISYS_tbl_UserPrivacyClassificationService<SYS_tbl_UserPrivacyClassification, SqlResult>
    {
        private readonly ISYS_tbl_UserPrivacyClassificationDal _sys_tbl_userPrivacyClassificationDal;

        public SYS_tbl_UserPrivacyClassificationManager(ISYS_tbl_UserPrivacyClassificationDal sys_tbl_UserPrivacyClassificationDal)
        {
            _sys_tbl_userPrivacyClassificationDal = sys_tbl_UserPrivacyClassificationDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_UserPrivacyClassification>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_UserPrivacyClassification>>(_sys_tbl_userPrivacyClassificationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_userPrivacyClassificationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
