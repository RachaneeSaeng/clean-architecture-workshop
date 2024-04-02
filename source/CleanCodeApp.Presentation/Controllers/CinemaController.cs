using CleanCodeApp.Application.Services;
using CleanCodeApp.Presentation.RequestModels;
using Microsoft.AspNetCore.Mvc;
using CleanCodeApp.Presentation.ObjectMappers;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.Controllers;

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
    [Route("GetShowTimesByMovieId/{movieId}")]
    public IEnumerable<ShowTimeDto> GetShowTimesByMovieId([FromRoute] Guid movieId)
    {
        var showTimes = _cinemaService.GetShowTimesByMovieId(movieId);
        return showTimes.Select(s => s.ToDto());
    }

    [HttpPost]
    [Route("CreateBooking")]
    public BookingDto CreateBooking([FromBody] CreateBookingRequestModel requestModel)
    {
        var booking = _cinemaService.CreateBooking(requestModel.ShowtimeId, requestModel.selectedSeatKeys, requestModel.CustomerAccountId);
        return booking.ToDto();
    }
}
