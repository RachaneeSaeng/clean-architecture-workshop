public class BookingRepository
{
    private static readonly List<Booking> Bookings = [];

    public void Save(Booking booking)
    {
        Bookings.Add(booking);
    }
}