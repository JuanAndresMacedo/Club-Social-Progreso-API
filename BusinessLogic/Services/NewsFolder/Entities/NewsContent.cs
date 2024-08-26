namespace BusinessLogic.Services.NewsFolder.Entities;

public class NewsContent
{
    public string Id { get; set; } 
    
    public string NewsId { get; set; } = null!;

    public string Paragraph { get; set; } = null!;
    
    public int Index { get; set; }

    public News News { get; set; }
    
    public NewsContent()
    {
        Id = Guid.NewGuid().ToString();
    }
}