using System.Globalization;
using System.Linq.Expressions;
using BusinessLogic.Services.NewsFolder.Entities;

namespace BusinessLogic.Services.NewsFolder;

public class NewsService : INewsService
{
    private readonly IRepository<News> _repository;
    
    public NewsService(IRepository<News> repository)
    {
        _repository = repository;
    }

    public News GetById(string newsId)
    {
        News news = _repository.Get(n => n.Id == newsId);
        news.Content = news.Content.OrderBy(c => c.Index).ToList();
        return news;
    }

    public List<News> GetAll(Expression<Func<News, bool>> predicate)
    {
        List<News> allNews = _repository.GetAll(predicate)
            .OrderByDescending(news => convertirStringAFecha(news.Date))
            .ToList();
        
        foreach (var news in allNews)
        {
            news.Content = news.Content.OrderBy(c => c.Index).ToList();
        }

        return allNews;
    }

    public List<News> GetLatestNews()
    {
        List<News> allNews = _repository.GetAll(news => true)
            .OrderByDescending(news => convertirStringAFecha(news.Date))
            .Take(6)
            .ToList();
        
        foreach (var news in allNews)
        {
            news.Content = news.Content.OrderBy(c => c.Index).ToList();
        }

        return allNews;
    }

    private DateTime convertirStringAFecha(string fechaString)
    {
        try
        {
            return DateTime.ParseExact(fechaString, "dd/MM/yyyy",
                CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            return DateTime.MinValue;
        }
    }
}