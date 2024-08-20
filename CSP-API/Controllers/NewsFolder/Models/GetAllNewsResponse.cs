using BusinessLogic.Services.NewsFolder.Entities;

namespace CSP_API.Controllers.NewsFolder.Models
{
    public sealed record class GetAllNewsResponse
    {
        public List<News> NewsList { get; }

        public GetAllNewsResponse(List<News> news)
        {
            NewsList = news;
        }
    }
}
