using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.Core.BL
{
    public interface ICommonBLOperationsService<Tentity, TSqlResult>
    {
        IDataResult<List<Tentity>> GetAllDataMngr(string module, string target, string point, string parameters);
        IDataResult<TSqlResult> ResultOperationsMngr(string module, string target, string point, string parameters);
    }
}
