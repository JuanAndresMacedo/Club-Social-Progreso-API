using BusinessLogic.Services.NewsFolder;
using CSP_API.Controllers.NewsFolder.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSP_API.Controllers.NewsFolder
{
    [ApiController]
    [Route("news")]
    public sealed class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }
        
        [HttpGet("/news/getById/{newsId}")]
        public GetNewsByIdResponse GetById(string newsId)
        {
            return new GetNewsByIdResponse(_newsService.GetById(newsId));
        }
        
        [HttpGet("/news/getLatestNews")]
        public GetAllNewsResponse GetLatestNews()
        {
            return new GetAllNewsResponse(_newsService.GetLatestNews());
        }

        [HttpGet("/news/getAll")]
        public GetAllNewsResponse GetAll()
        {
            return new GetAllNewsResponse(_newsService.GetAll(news => true));
        }
    }
}
