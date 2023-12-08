using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_OrganisationChangeHistoryManager : IHR_tbl_OrganisationChangeHistoryService<HR_tbl_OrganisationChangeHistory, SqlResult>
    {
        IHR_tbl_OrganisationChangeHistoryDal _hR_tbl_OrganisationChangeHistoryDal;

        public HR_tbl_OrganisationChangeHistoryManager(IHR_tbl_OrganisationChangeHistoryDal hR_tbl_OrganisationChangeHistoryDal)
        {
            _hR_tbl_OrganisationChangeHistoryDal = hR_tbl_OrganisationChangeHistoryDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(PositionValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_OrganisationChangeHistory>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_OrganisationChangeHistory>>(_hR_tbl_OrganisationChangeHistoryDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_OrganisationChangeHistoryDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
