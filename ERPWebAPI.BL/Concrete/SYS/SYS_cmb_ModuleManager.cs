using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;


namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_ModuleManager : ISYS_cmb_ModuleService<SYS_cmb_Module, SqlResult>
    {
        private readonly ISYS_cmb_ModuleDal _sYS_cmb_moduleDal;

        public SYS_cmb_ModuleManager(ISYS_cmb_ModuleDal sys_Cmb_ModulDal)
        {
            _sYS_cmb_moduleDal = sys_Cmb_ModulDal;
        }

        //[CacheAspect]
        public IDataResult<List<SYS_cmb_Module>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_Module>>(_sYS_cmb_moduleDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_cmb_moduleDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
