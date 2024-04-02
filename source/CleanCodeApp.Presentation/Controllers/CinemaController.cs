using Microsoft.AspNetCore.Mvc;
using System.Globalization;

[ApiController]
public class CinemaController(CinemaService cinemaService) : ControllerBase
{
    private readonly CinemaService _cinemaService = cinemaService;

    [HttpGet]
    [Route("GetNowShowingMovies")]
    public IEnumerable<MovieDto> GetNowShowingMovies()
    {
        var nowShowingMovies = _cinemaService.GetNowShowingMovies();
        return nowShowingMovies.Select(m => m.ToDto());
    }

    [HttpGet]
    [Route("SearchMoviesByTitle/{title}")]
    public IEnumerable<MovieDto> SearchMoviesByTitle([FromRoute] string title)
    {
        var movies = _cinemaService.SearchMoviesByTitle(title);
        return movies.Select(m => m.ToDto());
    }

    [HttpGet]
    [Route("GetMovieDetails/{movieId}")]
    public MovieDto GetMovieDetails([FromRoute] Guid movieId)
    {
        return _cinemaService.GetMovieDetails(movieId).ToDto();
    }

    [HttpGet]
    [Route("GetShowTimesByMovieIdAndDate/{movieId}/{date}")]
    public IEnumerable<ShowTimeDto> GetShowTimesByMovieIdAndDate([FromRoute] Guid movieId, string date)
    {
        var showTimes = _cinemaService.GetShowTimesByMovieIdAndDate(movieId, DateTime.Parse(date, CultureInfo.InvariantCulture));
        return showTimes.ToDto();
    }

    [HttpGet]
    [Route("GetShowTimesById/{showtimeId}")]
    public ShowTimeWithSeatsDto GetShowTimesById([FromRoute] Guid showtimeId)
    {
        var showTime = _cinemaService.GetShowTimeById(showtimeId);
        return showTime.ToDto();
    }

    [HttpPost]
    [Route("CreateBooking")]
    public BookingDto CreateBooking([FromBody] CreateBookingRequestModel requestModel)
    {
        var booking = _cinemaService.CreateBooking(requestModel.ShowtimeId, requestModel.selectedSeatKeys, requestModel.CustomerAccountId);
        return booking.ToDto();
    }
}
