using CleanCodeApp.Domain.Dependencies.Repositories;
using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Domain.Services;

namespace CleanCodeApp.Application.Services;

public class CinemaService(BookingService bookingService,
IBookingRepository bookingRepository,
    IMovieRepository movieRepository,
    IShowTimeRepository showTimeRepository,
    IPaymentHttpClient paymentHttpClient)
{
    private readonly BookingService _bookingService = bookingService;
    private readonly IBookingRepository _bookingRepository = bookingRepository;
    private readonly IMovieRepository _movieRepository = movieRepository;
    private readonly IShowTimeRepository _showTimeRepository = showTimeRepository;
    private readonly IPaymentHttpClient _paymentHttpClient = paymentHttpClient;

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

        var showtime = _showTimeRepository.GetById(showtimeId) ?? throw new Exception("Showtime not found.");

        try
        {
            var booking = _bookingService.CreateBooking(showtime, selectedSeats, customerAccountId);

            _paymentHttpClient.ProcessPayment(booking);

            booking.CompletePayment();

            _bookingRepository.Save(booking);

            return booking;
        }
        catch (Exception e)
        {
            throw new ApplicationException("Cannot creat booking successfully", e);
        }
    }
}