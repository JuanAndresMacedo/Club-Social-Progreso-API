namespace CSP_API.Controllers.NewsFolder.Models;

public sealed record class NewsDataResponse
{
    public string? Id { get; set; }
    
    public string? Title { get; set; }
    
    public string? Description { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public string? Date { get; set; }
    
    public string? Topic { get; set; }
    
    public bool? VerticalImage { get; set; }
    
    public List<string> Content { get; set; }
}