using CleanCodeApp.Infrastructure.Repositories;

namespace CleanCodeApp.Infrastructure.Tests;

public class ShowTimeRepositoryTests
{
    private readonly DateTime _today = DateTime.Today;

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
    public void TestGetShowTimesByMovieIdAndDate_ValidMovieIdAndDate()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieIdAndDate(movieRepo.SearchByTitle("Godzilla x Kong").First().Id, _today);

        // Assert
        Assert.Equal(3, showTimes.Count);
    }

    [Fact]
    public void TestGetShowTimesByMovieIdAndDate_ValidMovieIdButNoShowTimesForTheDate()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieIdAndDate(movieRepo.SearchByTitle("John Wick: Chapter 4").First().Id, _today);

        // Assert
        Assert.Empty(showTimes);
    }

    [Fact]
    public void TestGetShowTimesByMovieIdAndDate_ValidMovieIdWithoutShowTimesAtAll()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieIdAndDate(movieRepo.SearchByTitle("Joker").First().Id, _today);

        // Assert
        Assert.Empty(showTimes);
    }

    [Fact]
    public void TestGetShowTimesByMovieIdAndDate_InvalidMovieId()
    {
        // Arrange
        var movieRepo = new MovieRepository();
        var theaterRepo = new TheaterRepository();
        var showtimeRepo = new ShowTimeRepository(movieRepo, theaterRepo);

        // Act
        var showTimes = showtimeRepo.GetShowTimesByMovieIdAndDate(Guid.NewGuid(), _today);

        // Assert
        Assert.Empty(showTimes);
    }
}