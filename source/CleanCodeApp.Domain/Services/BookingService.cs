public class BookingService(ShowTimeRepository showtimeRepository, BookingRepository bookingRepository)
{
    // NOTE: Singleton instance may not be the best practice to create new instance of object
    // we use in just to accelerate development speed of the workshop only
    private static BookingService _instance;
    public static BookingService Instance
    {
        get
        {
            _instance ??= new BookingService(ShowTimeRepository.Instance, BookingRepository.Instance);
            return _instance;
        }
    }

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