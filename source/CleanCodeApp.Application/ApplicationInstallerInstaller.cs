using CleanCodeApp.Application.Services;
using Microsoft.Extensions.DependencyInjection;

public static class ApplicationInstaller
{
    public static void Install(IServiceCollection services)
    {
        services.AddScoped<CinemaService>();
    }
}