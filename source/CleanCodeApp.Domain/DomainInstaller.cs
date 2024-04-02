using Microsoft.Extensions.DependencyInjection;

public static class DomainInstaller
{
    public static void Install(IServiceCollection services)
    {
        services.AddScoped<BookingService>();
    }
}