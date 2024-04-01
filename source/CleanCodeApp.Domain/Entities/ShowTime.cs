namespace CleanCodeApp.Domain.Entities;

public class ShowTime(Movie movie, Theater theater, DateTime startTime, DateTime endTime)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Movie Movie { get; private set; } = movie;
    public DateTime StartTime { get; private set; } = startTime;
    public DateTime EndTime { get; private set; } = endTime;
    public Theater Theater { get; private set; } = theater;
    public List<Seat> Seats { get; private set; } = InitialiseSeats(theater.NumberOfRow, theater.NumberOfSeatsPerRow, theater.SeatPrice);
    public int SeatPrice { get; private set; }

    public void ReserveSeat(string row, int number)
    {
        var seat = Seats.FirstOrDefault(s => s.Row == row && s.Number == number) ??
                    throw new InvalidOperationException("There is no seat ${row}${number} in this showtime");

        seat.Reserve();
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
}
