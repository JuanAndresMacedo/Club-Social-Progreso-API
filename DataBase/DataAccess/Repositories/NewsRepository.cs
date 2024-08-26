using System.Linq.Expressions;
using BusinessLogic.Services.NewsFolder.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Repositories;

public class NewsRepository : Repository<News>
{
    public NewsRepository(DbContext context) : base(context)
    {
    }
    
    public override News? Get(Expression<Func<News, bool>> predicate)
    {
        var query =
            _entities.Include(n => n.Content)
                .Where(predicate);

        var news = query.FirstOrDefault();

        return news;
    }

    public override List<News> GetAll(Expression<Func<News, bool>> predicate)
    {
        var query =
            _entities.Include(n => n.Content)
                .Where(predicate)
                .ToList();

        return query;
    }
}