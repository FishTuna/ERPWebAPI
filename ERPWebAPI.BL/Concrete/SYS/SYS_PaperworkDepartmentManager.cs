

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_PaperworkDepartmentManager : ISYS_PaperworkDepartmentService<SYS_PaperworkDepartment, SqlResult>
    {
        ISYS_PaperworkDepartmentDal _sYS_PaperworkDepartmentDal;

        public SYS_PaperworkDepartmentManager(ISYS_PaperworkDepartmentDal sYS_PaperworkDepartmentDal)
        {
            _sYS_PaperworkDepartmentDal = sYS_PaperworkDepartmentDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<SYS_PaperworkDepartment>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_PaperworkDepartment>>(_sYS_PaperworkDepartmentDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_PaperworkDepartmentDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
