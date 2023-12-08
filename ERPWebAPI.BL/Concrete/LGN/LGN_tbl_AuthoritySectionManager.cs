using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_tbl_AuthoritySectionManager : ILGN_tbl_AuthoritySectionService<LGN_tbl_Authority_Section, SqlResult>
    {
        private readonly ILGN_tbl_AuthoritySectionDal _tbl_AuthoritySectionService;

        public LGN_tbl_AuthoritySectionManager(ILGN_tbl_AuthoritySectionDal lGN_tbl_AuthoritySectionDal)
        {
            _tbl_AuthoritySectionService = lGN_tbl_AuthoritySectionDal;
        }
        //[CacheAspect]
        public IDataResult<List<LGN_tbl_Authority_Section>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_Authority_Section>>(_tbl_AuthoritySectionService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _tbl_AuthoritySectionService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
