using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.OHS;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.OHS
{
    public class OHS_tbl_EmployeeListDal : IOHS_tbl_EmployeeListDal
    {
        public List<OHS_tbl_EmployeeList> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.OhsEmployeesList.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
