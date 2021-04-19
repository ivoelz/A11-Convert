namespace A11_Convert
{
    public class Search
    {
        public void SearchMovies()
        {
            Menu menu = new Menu();
            MovieContext db = new MovieContext();

            Console.WriteLine("Enter part of the title you'd like to search for: ");
            var search = Console.ReadLine();

            var movieList = db.Movie
            .FromSqlRaw($"SELECT * FROM db.Movie where Title like '%" + search + "%'").ToList();

            foreach (var displayMovie in movieList)
            {
            System.Console.WriteLine("ID: " + Movie.Id + "Title: " + Movie.Title);
            }
        }
    }
}