using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{
    public class HR_cmb_VacationGroupManager : IHR_cmb_VacationGroupService<HR_cmb_VacationGroup, SqlResult>
    {
        IHR_cmb_VacationGroupDal _hR_Cmb_VacationGroupDal;

        public HR_cmb_VacationGroupManager(IHR_cmb_VacationGroupDal hR_Cmb_VacationGroupDal)
        {
            _hR_Cmb_VacationGroupDal = hR_Cmb_VacationGroupDal;
        }
        public IDataResult<List<HR_cmb_VacationGroup>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_VacationGroup>>(_hR_Cmb_VacationGroupDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_Cmb_VacationGroupDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
