using System.Reflection.Metadata.Ecma335;
using CleanCodeApp.Domain.Dependencies.Repositories;

namespace CleanCodeApp.Domain.Entities;

public class ShowTimeScheduleService
{
    private readonly IMovieRepository _movieRepository;
    private readonly ITheaterRepository _theaterRepository;

    private readonly IShowTimeRepository _showtimeRepository;

    public ShowTimeScheduleService(IMovieRepository movieRepository, ITheaterRepository theaterRepository, IShowTimeRepository showtimeRepository)
    {
        _movieRepository = movieRepository;
        _theaterRepository = theaterRepository;
        _showtimeRepository = showtimeRepository;
    }

    public void ScheduleShowTime(Guid movieId, string theaterName, DateTime startTime, DateTime endTime)
    {
        var theater = _theaterRepository.GetByName(theaterName);

        if (IsOverlapseWithScheduledShowTimes(theater.ShowTimes, startTime, endTime))
            throw new InvalidOperationException("The theater is not available at this time");

        var movie = _movieRepository.GetById(movieId);

        var showTime = new ShowTime(movie, theater, startTime, endTime);

        theater.AddShowTimes(showTime);
        movie.AddShowTimes(showTime);
        _showtimeRepository.Save(showTime);
    }

    private bool IsOverlapseWithScheduledShowTimes(List<ShowTime> theatherShowtimes, DateTime startTime, DateTime endTime)
    {
        return theatherShowtimes.Any(st => st.StartTime.IsBetween(startTime, endTime) || st.EndTime.IsBetween(startTime, endTime));
    }
}
