using Microsoft.AspNetCore.Mvc;
using System.Globalization;

[ApiController]
public class CinemaController : ControllerBase
{
    [HttpGet]
    [Route("GetNowShowingMovies")]
    public IEnumerable<MovieDto> GetNowShowingMovies()
    {
        // TODO: create an application service or domain service to fetch data from repository and transform to DTO
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("SearchMoviesByTitle/{title}")]
    public IEnumerable<MovieDto> SearchMoviesByTitle([FromRoute] string title)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetMovieDetails/{movieId}")]
    public MovieDto GetMovieDetails([FromRoute] Guid movieId)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetShowTimesByMovieIdAndDate/{movieId}/{dateStr}")]
    public IEnumerable<ShowTimeDto> GetShowTimesByMovieIdAndDate([FromRoute] Guid movieId, string dateStr)
    {
        // TODO: create an application service or domain service to fetch data from repository and transform to DTO
        var date = DateTime.Parse(dateStr, CultureInfo.InvariantCulture);

        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetShowTimesById/{showtimeId}")]
    public ShowTimeWithSeatsDto GetShowTimesById([FromRoute] Guid showtimeId)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [Route("CreateBooking")]
    public BookingDto CreateBooking([FromBody] CreateBookingRequestModel requestModel)
    {
        // TODO: create an application service or domain service to create booking and process payment
        // Create Booking by reserving seats
        // process payment
        throw new NotImplementedException();
    }
}
