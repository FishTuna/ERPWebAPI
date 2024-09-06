using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.RPT
{
    public class RPT_ReportParamContentManager : IRPT_ReportParamContentService<RPT_ReportParamContent, SqlResult>
    {
        private readonly IRPT_ReportParamContentDal _rPT_ReportParamContentDal;

        public RPT_ReportParamContentManager(IRPT_ReportParamContentDal rPT_ReportParamContentDal)
        {
            _rPT_ReportParamContentDal = rPT_ReportParamContentDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<RPT_ReportParamContent>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<RPT_ReportParamContent>>(_rPT_ReportParamContentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _rPT_ReportParamContentDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
