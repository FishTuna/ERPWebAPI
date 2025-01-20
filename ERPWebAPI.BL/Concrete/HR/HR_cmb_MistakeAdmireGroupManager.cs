


using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_MistakeAdmireGroupManager : IHR_cmb_MistakeAdmireGroupService<HR_cmb_MistakeAdmireGroup, SqlResult>
    {
        IHR_cmb_MistakeAdmireGroupDal _hR_cmb_MistakeAdmireGroupDal;

        public HR_cmb_MistakeAdmireGroupManager(IHR_cmb_MistakeAdmireGroupDal hR_cmb_MistakeAdmireGroupDal)
        {
            _hR_cmb_MistakeAdmireGroupDal = hR_cmb_MistakeAdmireGroupDal;
        }
        //[CacheAspect]
        //[ValidationAspect(Groupof(MistakeAdmireGroupValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_MistakeAdmireGroup>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_MistakeAdmireGroup>>(_hR_cmb_MistakeAdmireGroupDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_MistakeAdmireGroupDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
