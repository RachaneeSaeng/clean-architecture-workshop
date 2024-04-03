using CleanCodeApp.Domain.Entities;

public interface IPaymentHttpClient
{
    string ProcessPayment(Booking booking);
}