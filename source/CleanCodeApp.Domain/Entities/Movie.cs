namespace CleanCodeApp.Domain.Entities;

public class Movie(string title, TimeSpan length, string description)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; } = title;
    public string Description { get; private set; } = description;
    public TimeSpan Length { get; private set; } = length;
}
