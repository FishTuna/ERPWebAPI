

using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_OrganizationPyramidDal : ISYS_OrganizationPyramidDal
    {
        public SYS_OrganizationPyramid Get(Expression<Func<SYS_OrganizationPyramid, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SYS_OrganizationPyramid> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysOrganizationPyramid.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
