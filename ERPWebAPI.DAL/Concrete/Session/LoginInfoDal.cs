
using ERPWebAPI.DAL.Abstract.Session;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.Session
{
    public class LoginInfoDal : ILoginInfoDal
    {
        public SqlResult SetLogOffInfo(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.sqlResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}"/*$"exec SYS_APPLOGOFFS_I {parameters}"*/).ToList().SingleOrDefault();
                return result;
            }
        }

        public SqlResult SetLoginInfo(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.sqlResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}"/*$"exec SYS_APPLOGINS_I {parameters}"*/).ToList().SingleOrDefault();
                return result;
            }
        }
    }
}
