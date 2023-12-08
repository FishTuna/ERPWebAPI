using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_LocationManager : IHR_cmb_LocationService<HR_cmb_Location, SqlResult>
    {
        IHR_cmb_LocationDal _hR_cmb_LocationDal;

        public HR_cmb_LocationManager(IHR_cmb_LocationDal hR_cmb_LocationDal)
        {
            _hR_cmb_LocationDal = hR_cmb_LocationDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(LocationValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_Location>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_Location>>(_hR_cmb_LocationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_LocationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
