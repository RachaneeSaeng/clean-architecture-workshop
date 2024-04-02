public class DefaultPaymentHttpClient
{
    // NOTE: Singleton instance may not be the best practice to create new instance of object
    // we use in just to accelerate development speed of the workshop only
    private static DefaultPaymentHttpClient _instance;
    public static DefaultPaymentHttpClient Instance
    {
        get
        {
            _instance ??= new DefaultPaymentHttpClient();
            return _instance;
        }
    }

    public string ProcessPayment(Booking booking)
    {
        // pretend that it call PaymentGateWay and success;
        return $"Successful payment with amount {booking.TotalPrice} for booking {booking.Id}";
    }
}