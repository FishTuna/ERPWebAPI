using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using System.Linq.Expressions;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_EmployeeOrganizationPyramidManager : ISYS_EmployeeOrganizationPyramidService<SYS_EmployeeOrganizationPyramid, SqlResult>
    {
        private readonly ISYS_EmployeeOrganizationPyramidDal _sys_EmployeeOrganizationPyramidDal;

        public SYS_EmployeeOrganizationPyramidManager(ISYS_EmployeeOrganizationPyramidDal sYS_EmployeeOrganizationPyramidDal)
        {
            _sys_EmployeeOrganizationPyramidDal = sYS_EmployeeOrganizationPyramidDal;
        }

        public SYS_EmployeeOrganizationPyramid Get(Expression<Func<SYS_EmployeeOrganizationPyramid, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SYS_EmployeeOrganizationPyramid>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_EmployeeOrganizationPyramid>>(_sys_EmployeeOrganizationPyramidDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_EmployeeOrganizationPyramidDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
