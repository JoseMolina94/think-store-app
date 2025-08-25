namespace ThinkApp.Api.Models;

public class Think
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Points { get; set; }
    public string? Image { get; set; } // Base64
    public string ColorBackground { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}