
using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.DAL.Concrete.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_tbl_EmergencyEmpJobManager : IOHS_tbl_EmergencyEmpJobService<OHS_tbl_EmergencyEmpJob, SqlResult>
    {
        private readonly IOHS_tbl_EmergencyEmpJobDal _oHS_tbl_EmergencyEmpJobDal;

        public OHS_tbl_EmergencyEmpJobManager(IOHS_tbl_EmergencyEmpJobDal oHS_tbl_EmergencyEmpJobDal)
        {
            _oHS_tbl_EmergencyEmpJobDal = oHS_tbl_EmergencyEmpJobDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_tbl_EmergencyEmpJob>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_tbl_EmergencyEmpJob>>(_oHS_tbl_EmergencyEmpJobDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_tbl_EmergencyEmpJobDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
