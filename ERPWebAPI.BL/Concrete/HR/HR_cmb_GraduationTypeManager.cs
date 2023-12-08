using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_GraduationTypeManager : IHR_cmb_GraduationTypeService<HR_cmb_GraduationType, SqlResult>
    {
        IHR_cmb_GraduationTypeDal _hR_cmb_GraduationTypeDal;
        public HR_cmb_GraduationTypeManager(IHR_cmb_GraduationTypeDal _hr_Cmb_GraduationTypeDal)
        {
            _hR_cmb_GraduationTypeDal = _hr_Cmb_GraduationTypeDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(GraduationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_GraduationType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_GraduationType>>(_hR_cmb_GraduationTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_GraduationTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
