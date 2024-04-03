using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Services;

public class BookingService
{
    public Booking CreateBooking(ShowTime showtime, List<string> selectedSeats, string customerAccountId)
    {
        List<Seat> seats = [];
        try
        {
            foreach (var seatStr in selectedSeats)
            {
                var seat = showtime.ReserveSeat(seatStr[..1], int.Parse(seatStr[1..]));
                seats.Add(seat);
            }
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Cannot reserve all specified seats", e);
        }

        return new Booking(showtime, seats, customerAccountId);
    }
}