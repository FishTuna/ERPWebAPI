using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_ContactTypeManager : IHR_cmb_ContactTypeService<HR_cmb_ContactType, SqlResult>
    {
        IHR_cmb_ContactTypeDal _hR_cmb_ContactTypeDal;

        public HR_cmb_ContactTypeManager(IHR_cmb_ContactTypeDal hR_cmb_ContactTypeDal)
        {
            _hR_cmb_ContactTypeDal = hR_cmb_ContactTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(ContactInfoTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_ContactType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_ContactType>>(_hR_cmb_ContactTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_ContactTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
