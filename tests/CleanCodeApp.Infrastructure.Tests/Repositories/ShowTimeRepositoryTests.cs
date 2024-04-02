using CleanCodeApp.Infrastructure.Repositories;

namespace CleanCodeApp.Infrastructure.Tests;

public class ShowTimeRepositoryTests
{
    [Fact]
    public void TestGetNowShowingMovies()
    {
        // Arrange
        var showtimeRepo = new ShowTimeRepository(new MovieRepository(), new TheaterRepository());

        // Act
        var nowShowingMovies = showtimeRepo.GetNowShowingMovies();

        // Assert
        Assert.Equal(3, nowShowingMovies.Count);
        Assert.Contains(nowShowingMovies, m => m.Title == "Godzilla x Kong: The New Empire");
        Assert.Contains(nowShowingMovies, m => m.Title == "Kung Fu Panda 4");
        Assert.Contains(nowShowingMovies, m => m.Title == "หอแต๋วแตก แหกสัปะหยด");
    }

    [Fact]
    public void TestGetShowTimesByMovieId_ValidMovieIdWithShowTimes()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieId(movieRepo.SearchByTitle("John Wick").First().Id);

        // Assert
        Assert.Equal(2, showTimes.Count);
    }

    [Fact]
    public void TestGetShowTimesByMovieId_ValidMovieIdWithoutShowTimes()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieId(movieRepo.SearchByTitle("Joker").First().Id);

        // Assert
        Assert.Empty(showTimes);
    }

    [Fact]
    public void TestGetShowTimesByMovieId_InvalidMovieId()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieId(Guid.NewGuid());

        // Assert
        Assert.Empty(showTimes);
    }
}