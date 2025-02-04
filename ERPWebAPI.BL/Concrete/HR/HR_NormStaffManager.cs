


using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_NormStaffManager : IHR_NormStaffService<HR_NormStaff, SqlResult>
    {
        IHR_NormStaffDal _hR_NormStaffDal;

        public HR_NormStaffManager(IHR_NormStaffDal hR_NormStaffDal)
        {
            _hR_NormStaffDal = hR_NormStaffDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_NormStaff>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_NormStaff>>(_hR_NormStaffDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_NormStaffDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
