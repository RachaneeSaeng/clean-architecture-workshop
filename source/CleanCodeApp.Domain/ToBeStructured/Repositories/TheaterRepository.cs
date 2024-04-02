public class TheaterRepository
{
    private static readonly Theater[] Theaters = [
        new Theater("Normal", 15, 20, 250),
        new Theater("4D", 25, 30, 500),
    ];

    public Theater GetByName(string name)
    {
        return Theaters.FirstOrDefault(t => t.Name == name);
    }
}