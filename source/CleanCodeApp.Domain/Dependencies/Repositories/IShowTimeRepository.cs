using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface IShowTimeRepository
{
    ShowTime GetById(Guid id);

    List<Movie> GetNowShowingMovies();

    List<ShowTime> GetShowTimesByMovieId(Guid movieId);
}