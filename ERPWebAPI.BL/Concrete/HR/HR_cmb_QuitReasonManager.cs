using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_QuitReasonManager : IHR_cmb_QuitReasonService<HR_cmb_QuitReason, SqlResult>
    {
        private readonly IHR_cmb_QuitReasonDal _hR_cmb_QuitReasonDal;

        public HR_cmb_QuitReasonManager(IHR_cmb_QuitReasonDal hR_cmb_QuitReasonDal)
        {
            _hR_cmb_QuitReasonDal = hR_cmb_QuitReasonDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(QuitReasonValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_QuitReason>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_QuitReason>>(_hR_cmb_QuitReasonDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_QuitReasonDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
