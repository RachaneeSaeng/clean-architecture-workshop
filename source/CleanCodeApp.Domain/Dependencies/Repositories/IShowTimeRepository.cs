using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface IShowTimeRepository
{
    public List<Movie> GetNowShowingMovies();

    public List<ShowTime> GetShowTimesByMovieId(Guid movieId);
}