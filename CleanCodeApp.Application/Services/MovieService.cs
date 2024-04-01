using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Application.Services;

public class MovieService : IMovieService
{
    // private readonly IMovieRepository _movieRepository;
    // private readonly IBookingRepository _bookingRepository;

    // public MovieService(IMovieRepository movieRepository, IBookingRepository bookingRepository)
    // {
    //     _movieRepository = movieRepository;
    //     _bookingRepository = bookingRepository;
    // }

    public List<Movie> SearchMoviesByTitle(string title)
    {
        // return _movieRepository.SearchByTitle(title);
        return null;
    }

    public Movie GetMovieDetails(int movieId)
    {
        // return _movieRepository.GetById(movieId);
        return null;
    }

    public Booking BookTickets(int showtimeId, int numberOfSeats, string customerAccountId)
    {
        // // Retrieve showtime details
        // var showtime = _movieRepository.GetShowtimeById(showtimeId);
        // if (showtime == null || showtime.GetAvailableSeats().Count() < numberOfSeats)
        //     throw new Exception("Showtime not found or not enough seats available.");

        // // Calculate total price
        // decimal totalPrice = showtime.Price * numberOfSeats;

        // // Update available seats
        // _movieRepository.UpdateShowtime(showtime);

        // // Create booking
        // var booking = new Booking
        // {
        //     Movie = showtime.Movie,
        //     Showtime = showtime,
        //     NumberOfSeats = numberOfSeats,
        //     TotalPrice = totalPrice,
        //     CustomerAccountId = customerAccountId,
        //     BookingReferenceId = GenerateBookingReferenceId() // Assume this generates a unique reference ID
        // };

        // _bookingRepository.Save(booking);

        // return booking;
        return null;
    }

    private string GenerateBookingReferenceId()
    {
        // Implement a logic to generate a unique booking reference ID
        return Guid.NewGuid().ToString();
    }
}