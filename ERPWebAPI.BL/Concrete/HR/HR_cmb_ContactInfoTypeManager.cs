using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_ContactInfoTypeManager : IHR_cmb_ContactInfoTypeService<HR_cmb_ContactInfoType, SqlResult>
    {
        IHR_cmb_ContactInfoTypeDal _hR_cmb_ContactInfoTypeDal;

        public HR_cmb_ContactInfoTypeManager(IHR_cmb_ContactInfoTypeDal hR_cmb_ContactInfoTypeDal)
        {
            _hR_cmb_ContactInfoTypeDal = hR_cmb_ContactInfoTypeDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(ContactInfoTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_ContactInfoType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_ContactInfoType>>(_hR_cmb_ContactInfoTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_ContactInfoTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
