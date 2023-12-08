using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_tbl_AuthorityRoleManager : ILGN_tbl_AuthorityRoleService<LGN_tbl_Authority_Role, SqlResult>
    {
        private readonly ILGN_tbl_AuthorityRoleDal _tbl_AuthorityRoleService;

        public LGN_tbl_AuthorityRoleManager(ILGN_tbl_AuthorityRoleDal lGN_tbl_AuthorityRoleDal)
        {
            _tbl_AuthorityRoleService = lGN_tbl_AuthorityRoleDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_tbl_Authority_Role>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_Authority_Role>>(_tbl_AuthorityRoleService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tbl_AuthorityRoleService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
