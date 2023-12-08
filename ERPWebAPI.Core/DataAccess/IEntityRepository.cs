using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint
    //referance tip olmalı
    //IEntity olmalı veya Ientity den türetilmiş olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Task<ActionResult<List<T>>> GetAll(string target,string point);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(T entity);
        T Get(Expression<Func<T, bool>> filter);
    }
}
