

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public  class SYS_SqlFunctionResultManager : ISYS_SqlFunctionResultService<SYS_SqlFunctionResult, SqlResult>
    {
        private readonly ISYS_SqlFunctionResultDal _sYS_FunctionResultDal;

        public SYS_SqlFunctionResultManager(ISYS_SqlFunctionResultDal sYS_FunctionResultDal)
        {
            _sYS_FunctionResultDal = sYS_FunctionResultDal;
        }
        //[CacheAspect]
        public IDataResult<List<SYS_SqlFunctionResult>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_SqlFunctionResult>>(_sYS_FunctionResultDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sYS_FunctionResultDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
