namespace Core.Entities
{
    public interface ISqlReturns<T>
    {
        T Add(string parameters);
        T Update(string parameters);
        T Delete(string parameters);
        //T PostPutDelete(string module, string target, string point, string parameters);
    }
}
