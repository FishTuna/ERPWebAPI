using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_SchoolDepartmentManager : IHR_cmb_SchoolDepartmentService<HR_cmb_SchoolDepartment, SqlResult>
    {
        private readonly IHR_cmb_SchoolDepartmentDal _hR_cmb_SchoolDepartmentDal;

        public HR_cmb_SchoolDepartmentManager(IHR_cmb_SchoolDepartmentDal hR_cmb_SchoolDepartmentDal)
        {
            _hR_cmb_SchoolDepartmentDal = hR_cmb_SchoolDepartmentDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolDepartmentValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_SchoolDepartment>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_SchoolDepartment>>(_hR_cmb_SchoolDepartmentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_SchoolDepartmentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
