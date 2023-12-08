using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_DepartmentManager : IHR_cmb_DepartmentService<HR_cmb_Department, SqlResult>
    {
        IHR_cmb_DepartmentDal _hR_cmb_DepartmentDal;

        public HR_cmb_DepartmentManager(IHR_cmb_DepartmentDal hR_cmb_DepartmentDal)
        {
            _hR_cmb_DepartmentDal = hR_cmb_DepartmentDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(DepartmentValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_Department>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_Department>>(_hR_cmb_DepartmentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_DepartmentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
