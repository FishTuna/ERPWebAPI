using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.HR;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.HR;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.HR;

namespace ERPWebAPI.BL.Concrete.HR
{

    public class HR_cmb_PositionManager : IHR_cmb_PositionService<HR_cmb_Position, SqlResult>
    {
        IHR_cmb_PositionDal _hR_cmb_PositionDal;

        public HR_cmb_PositionManager(IHR_cmb_PositionDal hR_cmb_PositionDal)
        {
            _hR_cmb_PositionDal = hR_cmb_PositionDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(PositionValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<HR_cmb_Position>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<HR_cmb_Position>>(_hR_cmb_PositionDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _hR_cmb_PositionDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
