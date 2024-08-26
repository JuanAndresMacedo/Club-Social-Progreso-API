using BusinessLogic.Services.NewsFolder.Entities;

namespace CSP_API.Controllers.NewsFolder.Models;

public sealed record class GetNewsByIdResponse
{
    public NewsDataResponse News { get; }

    public GetNewsByIdResponse(News news)
    {
        List<string> content = new List<string>();

        foreach (var newsContent in news.Content)
        {
            content.Add(newsContent.Paragraph);
        }

        NewsDataResponse newsData = new NewsDataResponse()
        {
            Id = news.Id,
            Title = news.Title,
            Description = news.Description,
            ImageUrl = news.ImageUrl,
            Date = news.Date,
            Topic = news.Topic,
            VerticalImage = news.VerticalImage,
            Content = content
        };
        
        News = newsData;
    }
}
