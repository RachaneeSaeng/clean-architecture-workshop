using Microsoft.AspNetCore.Mvc;
using System.Globalization;

[ApiController]
public class CinemaController : ControllerBase
{
    // TODO: 1. Organize and structure files in CleanCodeApp.Domain/ToBeStructured folder to be in a proper layer and folder
    // TODO: 2. replace `object` with proper class name

    [HttpGet]
    [Route("GetNowShowingMovies")]
    public IEnumerable<object> GetNowShowingMovies()
    {
        // TODO: 3. Implement logic to fetch data from repository in a proper (new or existing) class then transform to DTO
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
        // TODO: 4. Implement logic to fetch data from repository in a proper (new or existing) class then transform to DTO
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
        // TODO: 5. Implement logic to create booking and process payment in a proper (new or existing) class then transform to DTO 
        // 5.1 Create Booking by reserving seats
        // 5.2 Process payment
        throw new NotImplementedException();
    }
}
