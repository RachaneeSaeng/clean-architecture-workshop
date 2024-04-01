namespace CleanCodeApp.Domain.Entities;

public class ShowTime
{
    public Guid Id { get; private set; }
    public Movie Movie { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public Theater Theater { get; private set; }
    public List<Seat> Seats { get; private set; }
    public int SeatPrice { get; private set; }

    public ShowTime(Movie movie, Theater theater, DateTime startTime, DateTime endTime)
    {
        Id = Guid.NewGuid();
        Movie = movie;
        Theater = theater;
        StartTime = startTime;
        EndTime = endTime;
        Seats = InitialiseSeats(theater.NumberOfRow, theater.NumberOfSeatsPerRow, theater.SeatPrice);
    }

    private static List<Seat> InitialiseSeats(int numberOfRow, int numberOfSeatsPerRow, int seatPrice)
    {
        List<Seat> seats = [];
        for (int row = 1; row <= numberOfRow; row++)
        {
            for (int number = 1; number <= numberOfSeatsPerRow; number++)
            {
                seats.Add(new Seat(GetCharacterFromNumber(row).ToString(), number, seatPrice));
            }
        }
        return seats;
    }

    private static char GetCharacterFromNumber(int number)
    {
        if (number < 1 || number > 26)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 26");
        }

        // 'A' has an ASCII value of 65, add number - 1 to get the desired character
        return (char)('A' + number - 1);
    }

    public void ReserveSeat(string row, int number)
    {
        Seats.FirstOrDefault(s => s.Row == row && s.Number == number)?.Reserve();
    }
}
