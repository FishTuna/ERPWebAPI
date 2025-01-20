


using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_AuthorityFieldManager : ILGN_AuthorityFieldService<LGN_tbl_Authority_Field, SqlResult>
    {
        private readonly ILGN_AuthorityFieldDal _authfieldService;

        public LGN_AuthorityFieldManager(ILGN_AuthorityFieldDal lGN_AuthFieldDal)
        {
            _authfieldService = lGN_AuthFieldDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_tbl_Authority_Field>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_Authority_Field>>(_authfieldService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _authfieldService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
