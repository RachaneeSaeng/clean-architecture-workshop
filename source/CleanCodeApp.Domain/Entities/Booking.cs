namespace CleanCodeApp.Domain.Entities;

public class Booking(ShowTime showTime, List<Seat> seats, string customerAccountId)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public ShowTime ShowTime { get; private set; } = showTime;
    public List<Seat> Seats { get; private set; } = seats;
    public int TotalPrice { get; private set; } = seats.Sum(s => s.Price);
    public string CustomerAccountId { get; private set; } = customerAccountId;
    public bool Paid { get; private set; } = false;

    public void CompletePayment()
    {
        Paid = true;
    }
}