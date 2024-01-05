
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.PRF
{
    public class PRF_cmb_AnswerRatingDal : IPRF_cmb_AnswerRatingDal
    {
        public List<PRF_cmb_AnswerRating> GetAllDataDal(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.PrfAnswerRatings.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList();
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
