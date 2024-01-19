using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_OrganisationPyramidTitleManager : ISYS_cmb_OrganisationPyramidTitleService<SYS_cmb_OrganisationPyramidTitle, SqlResult>
    {
        private readonly ISYS_cmb_OrganisationPyramidTitleDal _sYS_Cmb_OrganisationPyramidTitleDal;

        public SYS_cmb_OrganisationPyramidTitleManager(ISYS_cmb_OrganisationPyramidTitleDal sys_cmb_OrganisationPyramidTitleDal)
        {
            _sYS_Cmb_OrganisationPyramidTitleDal = sys_cmb_OrganisationPyramidTitleDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_cmb_OrganisationPyramidTitle>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_OrganisationPyramidTitle>>(_sYS_Cmb_OrganisationPyramidTitleDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_Cmb_OrganisationPyramidTitleDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
