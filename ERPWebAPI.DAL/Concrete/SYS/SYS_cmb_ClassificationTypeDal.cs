﻿using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.SYS
{
    public class SYS_cmb_ClassificationTypeDal : ISYS_cmb_ClassificationTypeDal
    {
        public List<SYS_cmb_ClassificationType> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.SysClassificationTypes.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
