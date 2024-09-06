
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;
using ERPWebAPI.DAL.Abstract.HR;

namespace ERPWebAPI.DAL.Concrete.HR
{
    public class HR_ResumeHiringProcessResultDal : IHR_ResumeHiringProcessResultDal
    {
        public List<HR_ResumeHiringProcessResult> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.HrResumeHiringProcessResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
