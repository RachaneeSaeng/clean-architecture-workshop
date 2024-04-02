public class BookingRepository
{
    // NOTE: Singleton instance may not be the best practice to create new instance of object
    // we use in just to accelerate development speed of the workshop only
    private static BookingRepository _instance;
    public static BookingRepository Instance
    {
        get
        {
            _instance ??= new BookingRepository();
            return _instance;
        }
    }

    private static readonly List<Booking> Bookings = [];

    public void Save(Booking booking)
    {
        Bookings.Add(booking);
    }
}