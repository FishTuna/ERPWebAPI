﻿

using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_tbl_OrganisationPyramidMatchDal : ISYS_tbl_OrganisationPyramidMatchDal
    {
        public List<SYS_tbl_OrganisationPyramidMatch> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysOrganisationPyramidMatches.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
