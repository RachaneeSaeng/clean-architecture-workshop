using CleanCodeApp.Domain.ValueObjects;

namespace CleanCodeApp.Presentation.DTOs;

public class ShowTimeDto
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string TheaterName { get; set; }
    public List<SeatDto> Seats { get; set; }
    public int SeatPrice { get; set; }
}
