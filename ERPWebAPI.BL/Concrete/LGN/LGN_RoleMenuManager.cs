


using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_RoleMenuManager : ILGN_RoleMenuService<LGN_RoleMenu, SqlResult>
    {
        private readonly ILGN_RoleMenuDal _RoleMenuService;

        public LGN_RoleMenuManager(ILGN_RoleMenuDal lGN_RoleMenuDal)
        {
            _RoleMenuService = lGN_RoleMenuDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_RoleMenu>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_RoleMenu>>(_RoleMenuService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _RoleMenuService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
