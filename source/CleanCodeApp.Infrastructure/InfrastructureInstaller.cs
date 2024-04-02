using CleanCodeApp.Domain.Dependencies.Repositories;
using CleanCodeApp.Infrastructure.HttpClients;
using CleanCodeApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class InfrastructureInstaller
{
    public static void Install(IServiceCollection services)
    {
        services.AddSingleton<IBookingRepository, BookingRepository>();
        services.AddSingleton<IMovieRepository, MovieRepository>();
        services.AddSingleton<IShowTimeRepository, ShowTimeRepository>();
        services.AddSingleton<ITheaterRepository, TheaterRepository>();

        services.AddSingleton<IPaymentHttpClient, DefaultPaymentHttpClient>();
    }
}