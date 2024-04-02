using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.ObjectMappers;

public static class ShowTimeMapper
{
    public static ShowTimeDto ToDto(this ShowTime source)
    {
        return new ShowTimeDto()
        {
            Id = source.Id,
            MovieId = source.Movie.Id,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
            TheaterName = source.Theater.Name,
            Seats = source.Seats.Select(s => s.ToDto()).ToList(),
            SeatPrice = source.SeatPrice
        };
    }
}


