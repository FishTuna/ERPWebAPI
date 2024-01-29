using Core.Utilities.Results;
using ERPWebAPI.EL.Concrete.RPT;
using System.Dynamic;

namespace ERPWebAPI.BL.Abstract.RPT
{
    public interface IRPT_DynamicReportResultService
    {
        //IDataResult<List<RPT_DynamicReportResult>> GetDynamicReportResultMng(string module, string procedure, string procedureParams);
        IDataResult<List<ExpandoObject>> GetDynamicReportResultMng(string module, string procedure, string procedureParams);
    }
}
