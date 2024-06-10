using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.RPT;
using ERPWebAPI.DAL.Abstract.RPT;
using ERPWebAPI.EL.Concrete.RPT;
using System.Dynamic;

namespace ERPWebAPI.BL.Concrete.RPT
{
    public class RPT_DynamicReportResultManager : IRPT_DynamicReportResultService
    {
        private readonly IRPT_DynamicReportResultDal _rPT_DynamicReportResultDal;

        public RPT_DynamicReportResultManager(IRPT_DynamicReportResultDal rPT_DynamicReportResultDal)
        {
            _rPT_DynamicReportResultDal = rPT_DynamicReportResultDal;
        }
        //public IDataResult<List<RPT_DynamicReportResult>> GetDynamicReportResultMng(string module, string procedure, string procedureParams)
        //{
        //    string procName = $"{module}_{procedure}";
        //    var result = _rPT_DynamicReportResultDal.GetDynamicReportResultDal(procName, procedureParams);
        //    if (result.IsSuccess)
        //        return new SuccessDataResult<List<RPT_DynamicReportResult>>(result.Data);
        //    return new ErrorDataResult<List<RPT_DynamicReportResult>>(result.Data, result.Message);
        //}
        public IDataResult<List<ExpandoObject>> GetDynamicReportResultMng(string module, string procedure, string procedureParams)
        {
            string procName = $"{module}_{procedure}";
            var result = _rPT_DynamicReportResultDal.GetExpandoReportResultDal(procName, procedureParams);
            if (result.IsSuccess)
                return new SuccessDataResult<List<ExpandoObject>>(result.Data);
            return new ErrorDataResult<List<ExpandoObject>>(result.Data, result.Message);
        }
    }
}
