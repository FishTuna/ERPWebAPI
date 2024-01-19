

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_tbl_EmployeeListManager : IPRF_tbl_EmployeeListService<PRF_tbl_EmployeeList, SqlResult>
    {
        private readonly IPRF_tbl_EmployeeListDal _pRF_tbl_EmployeeListDal;

        public PRF_tbl_EmployeeListManager(IPRF_tbl_EmployeeListDal pRF_tbl_EmployeeListDal)
        {
            _pRF_tbl_EmployeeListDal = pRF_tbl_EmployeeListDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_tbl_EmployeeList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_tbl_EmployeeList>>(_pRF_tbl_EmployeeListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_tbl_EmployeeListDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
