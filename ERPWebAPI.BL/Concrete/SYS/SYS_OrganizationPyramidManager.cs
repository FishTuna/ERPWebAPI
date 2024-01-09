using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using System.Linq.Expressions;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_OrganizationPyramidManager : ISYS_OrganizationPyramidService<SYS_OrganizationPyramid, SqlResult>
    {
        private readonly ISYS_OrganizationPyramidDal _sys_OrganizationPyramidDal;

        public SYS_OrganizationPyramidManager(ISYS_OrganizationPyramidDal sYS_OrganizationPyramidDal)
        {
            _sys_OrganizationPyramidDal = sYS_OrganizationPyramidDal;
        }

        public SYS_OrganizationPyramid Get(Expression<Func<SYS_OrganizationPyramid, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SYS_OrganizationPyramid>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_OrganizationPyramid>>(_sys_OrganizationPyramidDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_OrganizationPyramidDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
