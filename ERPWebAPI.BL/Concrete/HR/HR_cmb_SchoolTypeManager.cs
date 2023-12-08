using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_SchoolTypeManager : IHR_cmb_SchoolTypeService<HR_cmb_SchoolType, SqlResult>
    {
        IHR_cmb_SchoolTypeDal _hR_cmb_SchoolTypeDal;

        public HR_cmb_SchoolTypeManager(IHR_cmb_SchoolTypeDal hR_cmb_SchoolTypeDal)
        {
            _hR_cmb_SchoolTypeDal = hR_cmb_SchoolTypeDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(SchoolTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_SchoolType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_SchoolType>>(_hR_cmb_SchoolTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_SchoolTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
