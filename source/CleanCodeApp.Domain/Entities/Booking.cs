namespace CleanCodeApp.Domain.Entities;

public class Booking(ShowTime showTime, List<Seat> seats, string customerAccountId)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public ShowTime ShowTime { get; set; } = showTime;
    public List<Seat> Seats { get; set; } = seats;
    public int TotalPrice { get; set; } = seats.Sum(s => s.Price);
    public string CustomerAccountId { get; set; } = customerAccountId;
    public bool Paid { get; set; } = false;

    public void CompletePayment()
    {
        Paid = true;
    }
}