public class Seat(string row, int number, int price)
{
    public string Row { get; private set; } = row;
    public int Number { get; private set; } = number;
    public int Price { get; private set; } = price;
    public bool IsAvailable { get; private set; } = true;

    public void Reserve()
    {
        if (!IsAvailable) throw new InvalidOperationException("Seat is already reserved.");
        IsAvailable = false;
    }
}