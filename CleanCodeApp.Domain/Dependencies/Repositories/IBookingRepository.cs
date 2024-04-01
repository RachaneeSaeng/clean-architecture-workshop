using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface IBookingRepository
{
    void Save(Booking booking);
}