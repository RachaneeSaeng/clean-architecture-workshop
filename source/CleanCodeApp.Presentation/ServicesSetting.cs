public static class ServicesSetting
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        // ApplicationInstaller.Install(services);
        // DomainInstaller.Install(services);
        // // Actually Presentation project should not refer to the Infrastucture project
        // // But this is needed to install dependencies injection
        // InfrastructureInstaller.Install(services);
    }
}
