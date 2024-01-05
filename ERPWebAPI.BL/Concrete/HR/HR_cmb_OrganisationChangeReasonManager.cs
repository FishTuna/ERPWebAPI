

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_OrganisationChangeReasonManager : IHR_cmb_OrganisationChangeReasonService<HR_cmb_OrganisationChangeReason, SqlResult>
    {
        IHR_cmb_OrganisationChangeReasonDal _hR_cmb_OrganisationChangeReasonDal;

        public HR_cmb_OrganisationChangeReasonManager(IHR_cmb_OrganisationChangeReasonDal hR_cmb_OrganisationChangeReasonDal)
        {
            _hR_cmb_OrganisationChangeReasonDal = hR_cmb_OrganisationChangeReasonDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(PositionValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_OrganisationChangeReason>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_OrganisationChangeReason>>(_hR_cmb_OrganisationChangeReasonDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_OrganisationChangeReasonDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
