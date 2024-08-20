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

        [HttpGet("/news/getAll")]
        public GetAllNewsResponse GetAll()
        {
            return new GetAllNewsResponse(_newsService.GetAll(news => true));
        }
    }
}
