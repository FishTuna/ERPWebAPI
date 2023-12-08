using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_DistrictManager : ISYS_cmb_DistrictService<SYS_cmb_District, SqlResult>
    {
        private readonly ISYS_cmb_DistrictDal _sYS_Cmb_DistrictDal;

        public SYS_cmb_DistrictManager(ISYS_cmb_DistrictDal sYS_Cmb_DistrictDal)
        {
            _sYS_Cmb_DistrictDal = sYS_Cmb_DistrictDal;
        }

        [CacheAspect]
        public IDataResult<List<SYS_cmb_District>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_District>>(_sYS_Cmb_DistrictDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_Cmb_DistrictDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
