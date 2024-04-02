public class CreateBookingRequestModel
{
    public Guid ShowtimeId { get; set; }
    public List<string> selectedSeatKeys { get; set; }
    public string CustomerAccountId { get; set; }
}
