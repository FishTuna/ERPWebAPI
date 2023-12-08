using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_tbl_MistakeAdmireManager : IHR_tbl_MistakeAdmireService<HR_tbl_MistakeAdmire, SqlResult>
    {
        private readonly IHR_tbl_MistakeAdmireDal _hR_tbl_MistakeAdmireDal;

        public HR_tbl_MistakeAdmireManager(IHR_tbl_MistakeAdmireDal hR_tbl_MistakeAdmireDal)
        {
            _hR_tbl_MistakeAdmireDal = hR_tbl_MistakeAdmireDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_tbl_MistakeAdmire>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_tbl_MistakeAdmire>>(_hR_tbl_MistakeAdmireDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_tbl_MistakeAdmireDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
