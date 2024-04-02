public interface IMovieRepository
{
    Movie GetById(Guid id);
    List<Movie> SearchByTitle(string title);
}