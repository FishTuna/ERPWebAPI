using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.HR
{
    public class HR_cmb_MaritalStatusDal : IHR_cmb_MaritalStatusDal
    {
        public List<HR_cmb_MaritalStatu> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.HrMaritalStatus.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
