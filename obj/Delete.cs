namespace A11_Convert
{
    public class Delete
    {
        public void DeleteMovie()
        {
            Menu menu = new Menu();
            
            System.Console.WriteLine("Which movie would you like to delete? (Enter the movie Id): ");
            var movieId = System.Console.ReadLine();

            var db = new MovieContext();
            var ogMovie = db.Movies.Single(a => a.Id  == movieIdDel);
            var genres = db.Genres.Where(b => EF.Property<int>(b, "MovieId") == movieIdDel);
            foreach (var genres in Genre)
            {
                movie.Genres.Remove(genres);
            }
            db.Remove(movie);
            db.SaveChanges();
        }
    }
}