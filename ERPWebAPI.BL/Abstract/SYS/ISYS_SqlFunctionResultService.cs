

using Core.BL;
using Core.Utilities.Results;
using ERPWebAPI.EL.Concrete.SYS;

namespace ERPWebAPI.BL.Abstract.SYS
{
    public interface ISYS_SqlFunctionResultService<TEntity, TSqlResult> : ICommonBLOperationsService<TEntity, TSqlResult>
    {
        public IDataResult<TEntity> GetDataMngr(string module, string target, string point, string parameters);
    }
}
