public class BookingService(ShowTimeRepository showtimeRepository, BookingRepository bookingRepository)
{
    private readonly ShowTimeRepository _showtimeRepository = showtimeRepository;
    private readonly BookingRepository _bookingRepository = bookingRepository;

    public Booking CreateBooking(Guid showtimeId, List<string> selectedSeats, string customerAccountId)
    {
        var showtime = _showtimeRepository.GetById(showtimeId) ?? throw new Exception("Showtime not found.");

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

        var booking = new Booking(showtime, seats, customerAccountId);
        _bookingRepository.Save(booking);

        return booking;
    }
}