public class CinemaService(IMovieRepository movieRepository,
    IShowTimeRepository showTimeRepository,
    IPaymentHttpClient paymentHttpClient,
    BookingService bookingService)
{
    private readonly IMovieRepository _movieRepository = movieRepository;
    private readonly IShowTimeRepository _showTimeRepository = showTimeRepository;
    private readonly IPaymentHttpClient _paymentHttpClient = paymentHttpClient;
    private readonly BookingService _bookingService = bookingService;

    public List<Movie> GetNowShowingMovies()
    {
        return _showTimeRepository.GetNowShowingMovies();
    }

    public List<Movie> SearchMoviesByTitle(string title)
    {
        return _movieRepository.SearchByTitle(title);
    }

    public Movie GetMovieDetails(Guid movieId)
    {
        return _movieRepository.GetById(movieId);
    }

    public List<ShowTime> GetShowTimesByMovieIdAndDate(Guid movieId, DateTime date)
    {
        return _showTimeRepository.GetShowTimesByMovieIdAndDate(movieId, date);
    }

    public ShowTime GetShowTimeById(Guid showtimeId)
    {
        return _showTimeRepository.GetById(showtimeId);
    }

    public Booking CreateBooking(Guid showtimeId, List<string> selectedSeats, string customerAccountId)
    {
        // ensure that seat is in format {row}{number} such as A10

        try
        {
            var booking = _bookingService.CreateBooking(showtimeId, selectedSeats, customerAccountId);

            _paymentHttpClient.ProcessPayment(booking);

            booking.CompletePayment();

            return booking;
        }
        catch (Exception e)
        {
            throw new ApplicationException("Cannot creat booking successfully", e);
        }
    }
}