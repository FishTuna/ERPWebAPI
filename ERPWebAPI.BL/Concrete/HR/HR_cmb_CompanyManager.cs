using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_CompanyManager : IHR_cmb_CompanyService<HR_cmb_Company, SqlResult>
    {
        IHR_cmb_CompanyDal _hR_cmb_CompanyDal;

        public HR_cmb_CompanyManager(IHR_cmb_CompanyDal hR_cmb_CompanyDal)
        {
            _hR_cmb_CompanyDal = hR_cmb_CompanyDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(CompanyValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_Company>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_Company>>(_hR_cmb_CompanyDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_CompanyDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
