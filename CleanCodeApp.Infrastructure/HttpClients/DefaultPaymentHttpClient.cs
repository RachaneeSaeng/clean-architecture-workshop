using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Infrastructure.HttpClients;

public class DefaultPaymentHttpClient : IPaymentHttpClient
{
    public string ProcessPayment(Booking booking)
    {
        // pretend that it call PaymentGateWay and success;
        return $"Successful payment with amount {booking.TotalPrice} for booking {booking.Id}";
    }
}