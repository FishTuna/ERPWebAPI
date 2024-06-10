

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_ProtocolMonitoringListManager : IOHS_ProtocolMonitoringListService<OHS_ProtocolMonitoringList, SqlResult>
    {
        IOHS_ProtocolMonitoringListDal _oHS_ProtocolMonitoringListDal;

        public OHS_ProtocolMonitoringListManager(IOHS_ProtocolMonitoringListDal oHS_ProtocolMonitoringListDal)
        {
            _oHS_ProtocolMonitoringListDal = oHS_ProtocolMonitoringListDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_ProtocolMonitoringList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_ProtocolMonitoringList>>(_oHS_ProtocolMonitoringListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_ProtocolMonitoringListDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
