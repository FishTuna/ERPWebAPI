using ERPWebAPI.DAL.Abstract.GRAPH;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.GRAPHS;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.GRAPH
{
    public class CommonGraphDal : ICommonGraphDal
    {
        public List<CommonGraph> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.CommonGraphs.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
