using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;


namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_CountryManager : ISYS_cmb_CountryService<SYS_cmb_Country, SqlResult>
    {
        private readonly ISYS_cmb_CountryDal _sYS_Cmb_CountryDal;

        public SYS_cmb_CountryManager(ISYS_cmb_CountryDal sYS_Cmb_CountryDal)
        {
            _sYS_Cmb_CountryDal = sYS_Cmb_CountryDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_Country>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_Country>>(_sYS_Cmb_CountryDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_Cmb_CountryDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
