using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.LGN;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.LGN;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.LGN;


namespace ERPWebAPI.BL.Concrete.LGN
{
    public class LGN_tbl_LoginUserManager : ILGN_tbl_LoginUserService<LGN_tbl_LoginUser, SqlResult>
    {
        private readonly ILGN_tbl_LoginUserDal _sys_tbl_loginUserDal;

        public LGN_tbl_LoginUserManager(ILGN_tbl_LoginUserDal syS_tbl_LoginUserDal)
        {
            _sys_tbl_loginUserDal = syS_tbl_LoginUserDal;
        }
        //[CacheAspect]
        public IDataResult<List<LGN_tbl_LoginUser>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<LGN_tbl_LoginUser>>(_sys_tbl_loginUserDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_tbl_loginUserDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
