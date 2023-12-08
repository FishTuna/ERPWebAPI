using Core.Utilities.Results;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.DAL.Concrete.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_tbl_EmployeeListManager : IOHS_tbl_EmployeeListService<OHS_tbl_EmployeeList, SqlResult>
    {
        private readonly IOHS_tbl_EmployeeListDal _oHS_tbl_EmployeeListDal;

        public OHS_tbl_EmployeeListManager(IOHS_tbl_EmployeeListDal oHS_tbl_EmployeeListDal)
        {
            _oHS_tbl_EmployeeListDal = oHS_tbl_EmployeeListDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_tbl_EmployeeList>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_tbl_EmployeeList>>(_oHS_tbl_EmployeeListDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_tbl_EmployeeListDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
