using System.Reflection.Metadata.Ecma335;

namespace CleanCodeApp.Domain.Entities;

public class Theater(string name, int numberOfRow, int numberOfSeatsPerRow, int seatPrice)
{
    public string Name { get; private set; } = name;

    public int NumberOfRow { get; private set; } = numberOfRow;

    public int NumberOfSeatsPerRow { get; private set; } = numberOfSeatsPerRow;

    public int SeatPrice { get; private set; } = seatPrice;
}
