public class MovieRepository : IMovieRepository
{
    private static readonly Movie[] movies = [
        new Movie("Godzilla x Kong: The New Empire", TimeSpan.FromHours(1.92), "Godzilla and the almighty Kong face a colossal threat hidden deep within the planet, challenging their very existence and the survival of the human race."),
        new Movie("Kung Fu Panda 4", TimeSpan.FromHours(1.6), "Kung Fu Panda 4 is a 2024 American animated martial arts comedy film produced by DreamWorks Animation and distributed by Universal Pictures. It is the fourth installment in the Kung Fu Panda franchise and the sequel to Kung Fu Panda 3"),
        new Movie("หอแต๋วแตก แหกสัปะหยด", TimeSpan.FromHours(1.08), "เจ๊แต๋ว อาโคย และ แพนเค้ก กับภาคสุดท้ายของหนังในตำนานของคนที่โตมากับ 'หอแต๋วแตก' เดินทางมาถึงภาค 10 เรื่องราวแปลกๆ ทั้งผี ทั้งคน ที่เกิดขึ้นในหมู่บ้าน 'สัปะหยด' แห่งนี้ เกิดจากใคร หรืออะไรกันแน่ ผีร้ายที่ว่าแน่ จะมาเก่งกว่าตัวมารดาของแทร่ได้ยังไง ฮาอาละวาดพร้อมกันในโรงภาพยนตร์"),
        new Movie("John Wick: Chapter 4", TimeSpan.FromHours(2.8), "Seventeen-year-old Rose hails from an aristocratic family and is set to be married. When she boards the Titanic, she meets Jack Dawson, an artist, and falls in love with him"),
        new Movie("Joker: Folie à Deux", TimeSpan.FromHours(2), "Joker: Folie à Deux is an upcoming American musical psychological thriller film slated to be a sequel to the 2019 film Joker. Joaquin Phoenix reprises his role as the DC Comics character the Joker, and Lady Gaga plays Harley Quinn"),
    ];

    public Movie GetById(Guid id)
    {
        return movies.FirstOrDefault(m => m.Id == id);
    }

    public List<Movie> SearchByTitle(string title)
    {
        return movies.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}