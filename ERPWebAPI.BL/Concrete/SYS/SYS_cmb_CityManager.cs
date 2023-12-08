using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;


namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_CityManager : ISYS_cmb_CityService<SYS_cmb_City, SqlResult>
    {
        private readonly ISYS_cmb_CityDal _sys_cmb_cityDal;

        public SYS_cmb_CityManager(ISYS_cmb_CityDal sys_cmb_CityDal)
        {
            _sys_cmb_cityDal = sys_cmb_CityDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_City>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_City>>(_sys_cmb_cityDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_cityDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
