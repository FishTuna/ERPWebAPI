using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.DAL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_cmb_EmergencyRegionManager : IOHS_cmb_EmergencyRegionService<OHS_cmb_EmergencyRegion, SqlResult>
    {
        private readonly IOHS_cmb_EmergencyRegionDal _oHS_cmb_EmergencyRegionDal;

        public OHS_cmb_EmergencyRegionManager(IOHS_cmb_EmergencyRegionDal oHS_cmb_EmergencyRegionDal)
        {
            _oHS_cmb_EmergencyRegionDal = oHS_cmb_EmergencyRegionDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_cmb_EmergencyRegion>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_cmb_EmergencyRegion>>(_oHS_cmb_EmergencyRegionDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_cmb_EmergencyRegionDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
