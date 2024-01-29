using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.DAL.Abstract.RPT;

namespace ERPWebAPI.BL.Concrete.RPT
{
    public class RPT_ReportParamManager : IRPT_ReportParamService<RPT_ReportParam, SqlResult>
    {
        private readonly IRPT_ReportParamDal _rPT_ReportParamDal;

        public RPT_ReportParamManager(IRPT_ReportParamDal rPT_ReportParamDal)
        {
            _rPT_ReportParamDal = rPT_ReportParamDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<RPT_ReportParam>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<RPT_ReportParam>>(_rPT_ReportParamDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _rPT_ReportParamDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
