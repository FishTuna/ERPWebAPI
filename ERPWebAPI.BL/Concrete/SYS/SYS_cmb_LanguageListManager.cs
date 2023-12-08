using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;


namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_LanguageListManager : ISYS_cmb_LanguageListService<SYS_cmb_LanguageList, SqlResult>
    {
        private readonly ISYS_cmb_LanguageListDal _sYS_Cmb_languagelistDal;

        public SYS_cmb_LanguageListManager(ISYS_cmb_LanguageListDal sYS_Cmb_LanguageListDal)
        {
            _sYS_Cmb_languagelistDal = sYS_Cmb_LanguageListDal;
        }

        //[CacheAspect]
        public IDataResult<List<SYS_cmb_LanguageList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_LanguageList>>(_sYS_Cmb_languagelistDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_Cmb_languagelistDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
