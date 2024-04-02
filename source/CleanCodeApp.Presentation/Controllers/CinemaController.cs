using Microsoft.AspNetCore.Mvc;
using System.Globalization;

[ApiController]
public class CinemaController : ControllerBase
{
    // TODO: replace `object` with class name
    [HttpGet]
    [Route("GetNowShowingMovies")]
    public IEnumerable<object> GetNowShowingMovies()
    {
        // TODO: create an application service or domain service to fetch data from repository and transform to DTO
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("SearchMoviesByTitle/{title}")]
    public IEnumerable<object> SearchMoviesByTitle([FromRoute] string title)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetMovieDetails/{movieId}")]
    public object GetMovieDetails([FromRoute] Guid movieId)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetShowTimesByMovieIdAndDate/{movieId}/{dateStr}")]
    public IEnumerable<object> GetShowTimesByMovieIdAndDate([FromRoute] Guid movieId, string dateStr)
    {
        // TODO: create an application service or domain service to fetch data from repository and transform to DTO
        var date = DateTime.Parse(dateStr, CultureInfo.InvariantCulture);

        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("GetShowTimesById/{showtimeId}")]
    public object GetShowTimesById([FromRoute] Guid showtimeId)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [Route("CreateBooking")]
    public object CreateBooking([FromBody] object requestModel)
    {
        // TODO: create an application service or domain service to create booking and process payment
        // Create Booking by reserving seats
        // process payment
        throw new NotImplementedException();
    }
}
