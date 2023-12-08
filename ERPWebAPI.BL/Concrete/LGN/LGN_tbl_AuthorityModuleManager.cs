using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_tbl_AuthorityModuleManager : ILGN_tbl_AuthorityModuleService<LGN_tbl_Authority_Module, SqlResult>
    {
        private readonly ILGN_tbl_AuthorityModuleDal _tbl_AuthorityModuleService;

        public LGN_tbl_AuthorityModuleManager(ILGN_tbl_AuthorityModuleDal lGN_tbl_AuthorityModuleDal)
        {
            _tbl_AuthorityModuleService = lGN_tbl_AuthorityModuleDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_tbl_Authority_Module>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_Authority_Module>>(_tbl_AuthorityModuleService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tbl_AuthorityModuleService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
