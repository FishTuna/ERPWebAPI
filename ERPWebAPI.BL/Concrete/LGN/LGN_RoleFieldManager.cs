


using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_RoleFieldManager : ILGN_RoleFieldService<LGN_RoleField, SqlResult>
    {
        private readonly ILGN_RoleFieldDal _RoleFieldService;

        public LGN_RoleFieldManager(ILGN_RoleFieldDal lGN_RoleFieldDal)
        {
            _RoleFieldService = lGN_RoleFieldDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_RoleField>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_RoleField>>(_RoleFieldService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _RoleFieldService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
