public interface IShowTimeRepository
{
    ShowTime GetById(Guid id);

    List<Movie> GetNowShowingMovies();

    List<ShowTime> GetShowTimesByMovieIdAndDate(Guid movieId, DateTime date);
}