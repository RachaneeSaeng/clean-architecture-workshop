using CleanCodeApp.Domain.ValueObjects;

namespace CleanCodeApp.Presentation.DTOs;

public class ShowTimeWithSeatsDto : ShowTimeDto
{
    public List<SeatDto> Seats { get; set; }
}
