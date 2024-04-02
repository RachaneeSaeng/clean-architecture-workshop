using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.ObjectMappers;

public static class SeatMapper
{
    public static SeatDto ToDto(this Seat source)
    {
        return new SeatDto()
        {
            Row = source.Row,
            Number = source.Number,
            Price = source.Price,
            IsAvailable = source.IsAvailable,
            SeatKey = $"{source.Row}{source.Number}"
        };
    }
}


