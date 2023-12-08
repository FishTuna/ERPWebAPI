using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;

namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_cmb_MenuManager : ILGN_cmb_MenuService<LGN_cmb_Menu, SqlResult>
    {
        private readonly ILGN_cmb_MenuDal _cmb_MenuService;

        public LGN_cmb_MenuManager(ILGN_cmb_MenuDal lGN_Cmb_MenuDal)
        {
            _cmb_MenuService = lGN_Cmb_MenuDal;
        }

        //[CacheAspect]
        public IDataResult<List<LGN_cmb_Menu>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_cmb_Menu>>(_cmb_MenuService.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _cmb_MenuService.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
