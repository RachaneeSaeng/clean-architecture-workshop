using Microsoft.Extensions.DependencyInjection;

public static class InfrastructureInstaller
{
    public static void Install(IServiceCollection services)
    {
        services.AddSingleton<BookingRepository>();
        services.AddSingleton<MovieRepository>();
        services.AddSingleton<ShowTimeRepository>();
        services.AddSingleton<TheaterRepository>();

        services.AddSingleton<DefaultPaymentHttpClient>();
    }
}