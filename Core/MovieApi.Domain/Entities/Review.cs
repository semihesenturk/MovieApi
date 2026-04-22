namespace MovieApi.Domain.Entities;

public class Review
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int UserRating { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}