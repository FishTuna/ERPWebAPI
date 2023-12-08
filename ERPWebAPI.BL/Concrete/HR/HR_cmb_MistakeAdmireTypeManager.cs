using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_MistakeAdmireTypeManager : IHR_cmb_MistakeAdmireTypeService<HR_cmb_MistakeAdmireType, SqlResult>
    {
        IHR_cmb_MistakeAdmireTypeDal _hR_cmb_MistakeAdmireTypeDal;

        public HR_cmb_MistakeAdmireTypeManager(IHR_cmb_MistakeAdmireTypeDal hR_cmb_MistakeAdmireTypeDal)
        {
            _hR_cmb_MistakeAdmireTypeDal = hR_cmb_MistakeAdmireTypeDal;
        }
        //[CacheAspect]
        //[ValidationAspect(typeof(MistakeAdmireTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_MistakeAdmireType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_MistakeAdmireType>>(_hR_cmb_MistakeAdmireTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_MistakeAdmireTypeDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
