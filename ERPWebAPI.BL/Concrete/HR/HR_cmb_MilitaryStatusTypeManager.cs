using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_MilitaryStatusTypeManager : IHR_cmb_MilitaryStatusTypeService<HR_cmb_MilitaryStatusType, SqlResult>
    {
        IHR_cmb_MilitaryStatusTypeDal _hR_cmb_MilitaryStatuTypeDal;

        public HR_cmb_MilitaryStatusTypeManager(IHR_cmb_MilitaryStatusTypeDal hR_cmb_MilitaryStatuTypeDal)
        {
            _hR_cmb_MilitaryStatuTypeDal = hR_cmb_MilitaryStatuTypeDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(MilitaryStatuTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_MilitaryStatusType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_MilitaryStatusType>>(_hR_cmb_MilitaryStatuTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_MilitaryStatuTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
