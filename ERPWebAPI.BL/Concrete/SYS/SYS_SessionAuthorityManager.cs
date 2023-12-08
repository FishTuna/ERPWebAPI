

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;
using System.Linq.Expressions;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_SessionAuthorityManager : ISYS_SessionAuthorityService<SYS_SessionAuthority, SqlResult>
    {
        private readonly ISYS_SessionAuthorityDal _sys_SessionAuthorityDal;

        public SYS_SessionAuthorityManager(ISYS_SessionAuthorityDal sYS_SessionAuthorityDal)
        {
            _sys_SessionAuthorityDal = sYS_SessionAuthorityDal;
        }

        public SYS_SessionAuthority Get(Expression<Func<SYS_SessionAuthority, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SYS_SessionAuthority>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_SessionAuthority>>(_sys_SessionAuthorityDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_SessionAuthorityDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
