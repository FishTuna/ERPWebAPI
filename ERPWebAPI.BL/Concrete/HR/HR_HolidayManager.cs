


using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_HolidayManager : IHR_HolidayService<HR_Holiday, SqlResult>
    {
        IHR_HolidayDal _hR_HolidayDal;

        public HR_HolidayManager(IHR_HolidayDal hR_HolidayDal)
        {
            _hR_HolidayDal = hR_HolidayDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(JobValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_Holiday>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_Holiday>>(_hR_HolidayDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_HolidayDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
