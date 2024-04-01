public static class DateTimeExtensions
{
    public static bool IsBetween(this DateTime dateToCheck, DateTime startDate, DateTime endDate)
    {
        // Adjust this based on your needs
        // Inclusive lower bound, exclusive upper bound
        return startDate <= dateToCheck && dateToCheck < endDate;
    }
}