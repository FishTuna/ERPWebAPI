using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_tbl_AuthorityMenuManager : ILGN_tbl_AuthorityMenuService<LGN_tbl_Authority_Menu, SqlResult>
    {
        private readonly ILGN_tbl_AuthorityMenuDal _tbl_AuthorityMenuService;

        public LGN_tbl_AuthorityMenuManager(ILGN_tbl_AuthorityMenuDal lGN_tbl_AuthorityMenuDal)
        {
            _tbl_AuthorityMenuService = lGN_tbl_AuthorityMenuDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_tbl_Authority_Menu>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_Authority_Menu>>(_tbl_AuthorityMenuService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tbl_AuthorityMenuService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
