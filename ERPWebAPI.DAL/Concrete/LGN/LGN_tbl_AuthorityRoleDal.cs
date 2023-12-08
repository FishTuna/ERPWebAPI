using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;
using Microsoft.EntityFrameworkCore;


namespace ERPWebAPI.DAL.Concrete.LGN
{
    public class LGN_tbl_AuthorityRoleDal : ILGN_tbl_AuthorityRoleDal
    {
        public List<LGN_tbl_Authority_Role> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.LgnAuthorityRoles.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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