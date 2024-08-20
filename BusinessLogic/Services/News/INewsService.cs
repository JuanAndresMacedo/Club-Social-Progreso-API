using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.News
{
    public interface INewsService
    {
        List<Entities.News> GetAll(Expression<Func<Entities.News, bool>> predicate);

        List<Entities.News> GetMainNews(Expression<Func<Entities.News, bool>> predicate);

        List<Entities.News> GetSecondaryNews(Expression<Func<Entities.News, bool>> predicate);
    }
}
