namespace CleanCodeApp.Domain.Entities;

public class Booking
{
    public int Id { get; set; }
    public ShowTime ShowTime { get; set; }
    public int NumberOfSeats { get; set; }
    public int TotalPrice { get; set; }
    public string CustomerAccountId { get; set; }
}