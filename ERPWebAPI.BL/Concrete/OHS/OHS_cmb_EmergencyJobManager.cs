using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.DAL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_cmb_EmergencyJobManager : IOHS_cmb_EmergencyJobService<OHS_cmb_EmergencyJob, SqlResult>
    {
        private readonly IOHS_cmb_EmergencyJobDal _oHS_cmb_EmergencyJobDal;

        public OHS_cmb_EmergencyJobManager(IOHS_cmb_EmergencyJobDal oHS_cmb_EmergencyJobDal)
        {
            _oHS_cmb_EmergencyJobDal = oHS_cmb_EmergencyJobDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_cmb_EmergencyJob>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_cmb_EmergencyJob>>(_oHS_cmb_EmergencyJobDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_cmb_EmergencyJobDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
