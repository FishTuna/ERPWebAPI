using ERPWebAPI.DAL.Abstract.RPT;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.RPT;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.RPT
{
    public class RPT_ReportListDal : IRPT_ReportListDal
    {
        public List<RPT_ReportList> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.RptReportsList.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
                return result;
            }
        }
        public SqlResult ResultOperationsDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                string param = $"exec {module}_{target}_{point} {parameters}";
                var result = context.sqlResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList().SingleOrDefault();
                return result;
            }
        }
    }
}
