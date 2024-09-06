using Core.Utilities.Results;
using ERPWebAPI.EL.Concrete.RPT;
using System.Dynamic;

namespace ERPWebAPI.DAL.Abstract.RPT
{
    public interface IRPT_DynamicReportResultDal
    {
        //IDataResult<List<RPT_DynamicReportResult>>GetDynamicReportResultDal(string procedure, string procedureParams);
        IDataResult<List<ExpandoObject>> GetExpandoReportResultDal(string procedure, string procedureParams);
    }
}
