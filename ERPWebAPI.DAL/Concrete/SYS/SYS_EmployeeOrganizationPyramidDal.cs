

using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ERPWebAPI.DAL.Abstract.SYS;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_EmployeeOrganizationPyramidDal : ISYS_EmployeeOrganizationPyramidDal
    {
        public SYS_EmployeeOrganizationPyramid Get(Expression<Func<SYS_EmployeeOrganizationPyramid, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SYS_EmployeeOrganizationPyramid> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysEmployeeOrganizationPyramid.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
