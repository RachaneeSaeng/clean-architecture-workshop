using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface IMovieRepository
{
    Movie GetById(Guid id);
    List<Movie> SearchByTitle(string title);
}