using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_BloodTypeManager : IHR_cmb_BloodTypeService<HR_cmb_BloodType, SqlResult>
    {
        IHR_cmb_BloodTypeDal _hR_cmb_BloodTypeDal;

        public HR_cmb_BloodTypeManager(IHR_cmb_BloodTypeDal hR_cmb_BloodTypeDal)
        {
            _hR_cmb_BloodTypeDal = hR_cmb_BloodTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(BloodTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_BloodType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_BloodType>>(_hR_cmb_BloodTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_BloodTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
