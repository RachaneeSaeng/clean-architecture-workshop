using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Application.Services;

public interface IMovieService
{
    List<Movie> SearchMoviesByTitle(string title);
    Movie GetMovieDetails(int movieId);
    Booking BookTickets(int showtimeId, int numberOfSeats, string customerAccountId);
}