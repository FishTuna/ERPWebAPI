using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_SchoolLocationManager : IHR_tbl_SchoolLocationService<HR_tbl_SchoolLocation, SqlResult>
    {
        private readonly IHR_tbl_SchoolLocationDal _hR_tbl_SchoolLocationDal;

        public HR_tbl_SchoolLocationManager(IHR_tbl_SchoolLocationDal hR_tbl_SchoolLocationDal)
        {
            _hR_tbl_SchoolLocationDal = hR_tbl_SchoolLocationDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolLocationValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_SchoolLocation>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_SchoolLocation>>(_hR_tbl_SchoolLocationDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_SchoolLocationDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
