

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_UnitTypeGroupManager : ISYS_cmb_UnitTypeGroupService<SYS_cmb_UnitTypeGroup, SqlResult>
    {
        private readonly ISYS_cmb_UnitTypeGroupDal _sYS_cmb_UnitTypeGroupDal;

        public SYS_cmb_UnitTypeGroupManager(ISYS_cmb_UnitTypeGroupDal sYS_cmb_UnitTypeGroupDal)
        {
            _sYS_cmb_UnitTypeGroupDal = sYS_cmb_UnitTypeGroupDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<SYS_cmb_UnitTypeGroup>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_UnitTypeGroup>>(_sYS_cmb_UnitTypeGroupDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_cmb_UnitTypeGroupDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
