using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_VacationGroupContentManager : IHR_tbl_VacationGroupContentService<HR_tbl_VacationGroupContent, SqlResult>
    {
        private readonly IHR_tbl_VacationGroupContentDal _hR_Tbl_VacationGroupContentDal;

        public HR_tbl_VacationGroupContentManager(IHR_tbl_VacationGroupContentDal hR_Tbl_VacationGroupContentDal)
        {
            _hR_Tbl_VacationGroupContentDal = hR_Tbl_VacationGroupContentDal;
        }
        public IDataResult<List<HR_tbl_VacationGroupContent>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_VacationGroupContent>>(_hR_Tbl_VacationGroupContentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_Tbl_VacationGroupContentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
