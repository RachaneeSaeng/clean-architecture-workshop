using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.ObjectMappers;

public static class ShowTimeMapper
{
    public static IEnumerable<ShowTimeDto> ToDto(this List<ShowTime> sources)
    {
        return sources
        .Select(s => new ShowTimeDto()
        {
            Id = s.Id,
            StartTime = s.StartTime,
            EndTime = s.EndTime,
            TheaterName = s.Theater.Name
        });
    }

    public static ShowTimeWithSeatsDto ToDto(this ShowTime source)
    {
        return new ShowTimeWithSeatsDto()
        {
            Id = source.Id,
            StartTime = source.StartTime,
            EndTime = source.EndTime,
            TheaterName = source.Theater.Name,
            Seats = source.Seats.Select(s => s.ToDto()).ToList()
        };
    }
}


