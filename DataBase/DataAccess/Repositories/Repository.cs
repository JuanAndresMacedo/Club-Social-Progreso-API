using System.Linq.Expressions;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    protected readonly DbSet<TEntity> _entities;

    private readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
        _entities = context.Set<TEntity>();
    }
    
    public virtual TEntity? Get(Expression<Func<TEntity, bool>> predicate)
    {
        var entity = _entities.FirstOrDefault(predicate);

        return entity;
    }

    public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
    {
        return _entities.Where(predicate).ToList();
    }
}