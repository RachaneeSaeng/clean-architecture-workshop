namespace CleanCodeApp.Presentation.DTOs;

public class BookingDto
{
    public Guid Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string TheaterName { get; set; }
    public List<SeatDto> Seats { get; set; }
    public int TotalPrice { get; set; }
    public string CustomerAccountId { get; set; }
}