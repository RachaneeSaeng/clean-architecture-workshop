using CleanCodeApp.Domain.Dependencies.Repositories;
using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Infrastructure.Repositories;

public class ShowTimeRepository : IShowTimeRepository
{
    private readonly List<ShowTime> ShowTimes;

    // this is just a temp constructor to mock up ShowTimes data
    public ShowTimeRepository(IMovieRepository movieRepo, ITheaterRepository theaterRepo)
    {
        ShowTime GenShowTime(string movieTitle, string theaterName, DateTime startTime, DateTime endTime)
        {
            return new ShowTime(movieRepo.SearchByTitle(movieTitle).First(), theaterRepo.GetByName(theaterName), startTime, endTime);
        }

        var today = DateTime.Today;
        var tomorrow = today.AddDays(1);

        ShowTimes = [
            GenShowTime("John Wick: Chapter 4", "Normal", DateTime.Parse("2023-03-24").AddHours(10.5), DateTime.Parse("2023-03-24").AddHours(14)),
            GenShowTime("John Wick: Chapter 4", "4D", DateTime.Parse("2023-03-24").AddHours(10.5), DateTime.Parse("2023-03-24").AddHours(14)),
            GenShowTime("Godzilla x Kong: The New Empire", "Normal", today.AddHours(-5), today.AddHours(-3)),
            GenShowTime("Godzilla x Kong: The New Empire", "Normal", today.AddHours(10.5), today.AddHours(13.0)),
            GenShowTime("Kung Fu Panda 4", "Normal", today.AddHours(13.5), today.AddHours(16.0)),
            GenShowTime("Godzilla x Kong: The New Empire", "Normal", today.AddHours(16.5), today.AddHours(19.0)),
            GenShowTime("หอแต๋วแตก แหกสัปะหยด", "Normal", today.AddHours(19.5), today.AddHours(22.0)),
            GenShowTime("Godzilla x Kong: The New Empire", "4D", today.AddHours(11.0), today.AddHours(13.5)),
            GenShowTime("Kung Fu Panda 4", "4D", today.AddHours(14.5), today.AddHours(15.5)),
            GenShowTime("Kung Fu Panda 4", "Normal", tomorrow.AddHours(13.5), tomorrow.AddHours(16.0)),
            GenShowTime("Godzilla x Kong: The New Empire", "Normal", tomorrow.AddHours(16.5), tomorrow.AddHours(19.0)),
            GenShowTime("หอแต๋วแตก แหกสัปะหยด", "Normal", tomorrow.AddHours(19.5), tomorrow.AddHours(22.0)),
            GenShowTime("Godzilla x Kong: The New Empire", "4D", tomorrow.AddHours(11.0), tomorrow.AddHours(13.5)),
            GenShowTime("Kung Fu Panda 4", "4D", tomorrow.AddHours(14.5), tomorrow.AddHours(15.5)),
        ];
    }

    public ShowTime GetById(Guid id)
    {
        return ShowTimes.FirstOrDefault(s => s.Id == id);
    }

    public List<Movie> GetNowShowingMovies()
    {
        return ShowTimes.Where(st => DateTime.Today <= st.StartTime && st.StartTime <= DateTime.Today.AddDays(15))
                        .Select(st => st.Movie)
                        .Distinct()
                        .ToList();
    }

    public List<ShowTime> GetShowTimesByMovieIdAndDate(Guid movieId, DateTime date)
    {
        return ShowTimes.Where(st => st.Movie.Id == movieId && st.StartTime >= date && st.StartTime < date.AddDays(1)).ToList();
    }
}