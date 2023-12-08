
using Core.Entities;

namespace Core.DataAccess
{
    public interface ICommonDalOperations<T, TSqlResults>
        where T : class, IEntity, new()
        where TSqlResults : class, IEntity, new()
    {
        List<T> GetAllDataDal(string module, string target, string point, string parameters);
        //T GetDataDal(Expression<Func<T, bool>> filter);
        TSqlResults ResultOperationsDal(string module, string target, string point, string parameters);
    }
}
