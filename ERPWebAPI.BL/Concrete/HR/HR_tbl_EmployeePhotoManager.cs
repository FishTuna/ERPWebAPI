using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_EmployeePhotoManager : IHR_tbl_EmployeePhotoService<HR_tbl_EmployeePhoto, SqlResult>
    {
        private readonly IHR_tbl_EmployeePhotoDal _hR_tbl_EmployeePhotoDal;

        public HR_tbl_EmployeePhotoManager(IHR_tbl_EmployeePhotoDal hR_tbl_EmployeePhotoDal)
        {
            _hR_tbl_EmployeePhotoDal = hR_tbl_EmployeePhotoDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_EmployeePhoto>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_EmployeePhoto>>(_hR_tbl_EmployeePhotoDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_EmployeePhotoDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
