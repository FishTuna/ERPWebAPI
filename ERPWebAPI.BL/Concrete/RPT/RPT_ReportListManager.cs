using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.RPT;
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.RPT
{
    public class RPT_ReportListManager : IRPT_ReportListService<RPT_ReportList, SqlResult>
    {
        private readonly IRPT_ReportListDal _rPT_ReportListDal;

        public RPT_ReportListManager(IRPT_ReportListDal rPT_ReportListDal)
        {
            _rPT_ReportListDal = rPT_ReportListDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<RPT_ReportList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<RPT_ReportList>>(_rPT_ReportListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _rPT_ReportListDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
