using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_SessionAuthorityDal : ISYS_SessionAuthorityDal
    {
        public SYS_SessionAuthority Get(Expression<Func<SYS_SessionAuthority, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SYS_SessionAuthority> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysSessionAuthorities.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
