

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_RoleModuleManager : ILGN_RoleModuleService<LGN_RoleModule, SqlResult>
    {
        private readonly ILGN_RoleModuleDal _fieldService;

        public LGN_RoleModuleManager(ILGN_RoleModuleDal LGN_RoleModuleDal)
        {
            _fieldService = LGN_RoleModuleDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_RoleModule>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_RoleModule>>(_fieldService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _fieldService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
