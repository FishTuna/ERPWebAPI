using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_tbl_OrganisationPyramidMatchManager : ISYS_tbl_OrganisationPyramidMatchService<SYS_tbl_OrganisationPyramidMatch, SqlResult>
    {
        private readonly ISYS_tbl_OrganisationPyramidMatchDal _sYS_tbl_OrganisationPyramidMatchDal;

        public SYS_tbl_OrganisationPyramidMatchManager(ISYS_tbl_OrganisationPyramidMatchDal sys_tbl_OrganisationPyramidMatchDal)
        {
            _sYS_tbl_OrganisationPyramidMatchDal = sys_tbl_OrganisationPyramidMatchDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_tbl_OrganisationPyramidMatch>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_tbl_OrganisationPyramidMatch>>(_sYS_tbl_OrganisationPyramidMatchDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_tbl_OrganisationPyramidMatchDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
