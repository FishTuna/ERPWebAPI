

using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.PRF
{
    public class PRF_tbl_OrganizationTargetDal : IPRF_tbl_OrganizationTargetDal
    {
        public List<PRF_tbl_OrganizationTarget> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.PrfOrganizationTargets.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
