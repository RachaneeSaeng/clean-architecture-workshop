using CleanCodeApp.Domain.Dependencies.Repositories;
using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Infrastructure.Repositories;

public class BookingRepository : IBookingRepository
{
    private static readonly List<Booking> Bookings = [];

    public void Save(Booking booking)
    {
        Bookings.Add(booking);
    }
}