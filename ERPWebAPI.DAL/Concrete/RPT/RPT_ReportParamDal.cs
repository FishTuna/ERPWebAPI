
using ERPWebAPI.EL.Concrete.RPT;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;
using ERPWebAPI.DAL.Abstract.RPT;

namespace ERPWebAPI.DAL.Concrete.RPT
{
    public class RPT_ReportParamDal : IRPT_ReportParamDal
    {
        public List<RPT_ReportParam> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.RptReportParams.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
