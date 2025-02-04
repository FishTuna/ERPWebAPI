


using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_PasswordPolicyManager : ILGN_PasswordPolicyService<LGN_PasswordPolicy, SqlResult>
    {
        private readonly ILGN_PasswordPolicyDal _passwordPolicyService;

        public LGN_PasswordPolicyManager(ILGN_PasswordPolicyDal lGN_PasswordPolicyDal)
        {
            _passwordPolicyService = lGN_PasswordPolicyDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_PasswordPolicy>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_PasswordPolicy>>(_passwordPolicyService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _passwordPolicyService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
