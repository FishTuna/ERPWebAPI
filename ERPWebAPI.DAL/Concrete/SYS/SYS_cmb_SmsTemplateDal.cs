
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_cmb_SmsTemplateDal : ISYS_cmb_SmsTemplateDal
    {
        public SYS_cmb_SmsTemplate Get(Expression<Func<SYS_cmb_SmsTemplate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SYS_cmb_SmsTemplate> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysSmsTemplates.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
