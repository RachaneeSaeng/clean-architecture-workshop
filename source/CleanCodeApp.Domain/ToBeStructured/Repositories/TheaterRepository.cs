public class TheaterRepository
{
    // NOTE: Singleton instance may not be the best practice to create new instance of object
    // we use in just to accelerate development speed of the workshop only
    private static TheaterRepository _instance;
    public static TheaterRepository Instance
    {
        get
        {
            _instance ??= new TheaterRepository();
            return _instance;
        }
    }

    private static readonly Theater[] Theaters = [
        new Theater("Normal", 15, 20, 250),
        new Theater("4D", 25, 30, 500),
    ];

    public Theater GetByName(string name)
    {
        return Theaters.FirstOrDefault(t => t.Name == name);
    }
}