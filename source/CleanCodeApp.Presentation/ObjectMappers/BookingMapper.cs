using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.ObjectMappers;

public static class BookingMapper
{
    public static BookingDto ToDto(this Booking source)
    {
        return new BookingDto()
        {
            Id = source.Id,
            StartTime = source.ShowTime.StartTime,
            EndTime = source.ShowTime.EndTime,
            TheaterName = source.ShowTime.Theater.Name,
            Seats = source.Seats.Select(s => s.ToDto()).ToList(),
            TotalPrice = source.TotalPrice,
            CustomerAccountId = source.CustomerAccountId
        };
    }
}


