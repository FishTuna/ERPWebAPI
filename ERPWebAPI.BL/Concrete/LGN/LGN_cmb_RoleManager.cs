using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_cmb_RoleManager : ILGN_cmb_RoleService<LGN_cmb_Role, SqlResult>
    {
        private readonly ILGN_cmb_RoleDal _cmb_RoleService;

        public LGN_cmb_RoleManager(ILGN_cmb_RoleDal lGN_Cmb_RoleDal)
        {
            _cmb_RoleService = lGN_Cmb_RoleDal;
        }
        //[CacheAspect]
        public IDataResult<List<LGN_cmb_Role>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_cmb_Role>>(_cmb_RoleService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _cmb_RoleService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }

}
