using Core.Utilities.Results;

namespace Core.BL
{
    public interface ICommonBLOperationsService<Tentity, TSqlResult>
    {
        IDataResult<List<Tentity>> GetAllDataMngr(string module, string target, string point, string parameters);
        IDataResult<TSqlResult> ResultOperationsMngr(string module, string target, string point, string parameters);
    }
}
