namespace NewsAppLibrary.Models;

public class Article
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public string? FeaturedImage { get; set; }
    public Author? Author { get; set; }
}