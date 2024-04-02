using Microsoft.Extensions.DependencyInjection;
using CleanCodeApp.Domain.Services;

public static class DomainInstaller
{
    public static void Install(IServiceCollection services)
    {
        services.AddScoped<BookingService>();
    }
}