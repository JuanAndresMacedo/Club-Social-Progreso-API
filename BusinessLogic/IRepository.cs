using System.Linq.Expressions;

namespace BusinessLogic;

public interface IRepository<TEntity>
    where TEntity : class
{
    TEntity? Get(Expression<Func<TEntity, bool>> predicate);

    List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
}