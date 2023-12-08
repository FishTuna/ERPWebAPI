using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;


namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_RegionManager : ISYS_cmb_RegionService<SYS_cmb_Region, SqlResult>
    {

        private readonly ISYS_cmb_RegionDal _sys_cmb_regionDal;

        public SYS_cmb_RegionManager(ISYS_cmb_RegionDal syS_cmb_RegionDal)
        {
            _sys_cmb_regionDal = syS_cmb_RegionDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_Region>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_Region>>(_sys_cmb_regionDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_regionDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
