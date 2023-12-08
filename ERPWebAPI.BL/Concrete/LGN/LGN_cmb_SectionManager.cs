using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_cmb_SectionManager : ILGN_cmb_SectionService<LGN_cmb_Section, SqlResult>
    {
        private readonly ILGN_cmb_SectionDal _cmb_SectionService;

        public LGN_cmb_SectionManager(ILGN_cmb_SectionDal lGN_Cmb_SectionDal)
        {
            _cmb_SectionService = lGN_Cmb_SectionDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_cmb_Section>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_cmb_Section>>(_cmb_SectionService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _cmb_SectionService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
