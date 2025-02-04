


using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_RoleSectionManager : ILGN_RoleSectionService<LGN_RoleSection, SqlResult>
    {
        private readonly ILGN_RoleSectionDal _RoleSectionService;

        public LGN_RoleSectionManager(ILGN_RoleSectionDal lGN_RoleSectionDal)
        {
            _RoleSectionService = lGN_RoleSectionDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_RoleSection>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_RoleSection>>(_RoleSectionService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _RoleSectionService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
