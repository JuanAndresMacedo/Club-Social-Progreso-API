using System.Globalization;
using System.Linq.Expressions;
using BusinessLogic.Services.NewsFolder.Entities;

namespace BusinessLogic.Services.NewsFolder;

public class NewsService : INewsService
{
    private readonly IRepository<News> _repository;
    private readonly List<News> _allNews = new List<News>();

    public NewsService(IRepository<News> repository)
    {
        //_repository = repository;
        _allNews.Add(
            new News
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Noticia de Ejemplo 1",
                Description = "Esta es la primera noticia de ejemplo",
                ImageUrl = "https://misitio.com/imagen1.jpg",
                Date = "01/03/2025",
                Topic = "Tecnología",
                VerticalImage = false,
                Content = new List<NewsContent>
            {
                new NewsContent
                {
                    Paragraph = "Párrafo 1 de la noticia 1",
                    Index = 0
                },
                new NewsContent
                {
                    Paragraph = "Párrafo 2 de la noticia 1",
                    Index = 1
                }
            }
            });
    }

    public News GetById(string newsId)
    {
        News news = _repository.Get(n => n.Id == newsId);
        news.Content = news.Content.OrderBy(c => c.Index).ToList();
        return news;
    }

    public List<News> GetAll(Expression<Func<News, bool>> predicate)
    {
        /*List<News> allNews = _repository.GetAll(predicate)
            .OrderByDescending(news => convertirStringAFecha(news.Date))
            .ToList();*/
        List<News> allNews = _allNews.ToList();

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