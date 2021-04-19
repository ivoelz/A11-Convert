using System;

namespace A11_Convert
{
    public class Add
    {
        public void AddMovie()
        {
            Menu menu = new Menu();
            UserAddTitle();
            var userAddTitle = Console.ReadLine();
            UserAddGenre();
            var userAddGenre = Console.ReadLine();

            using (var db = new MovieContext())
            {
                var movie = new MovieContext {Title = userAddTitle, Genres = userAddGenre};
            }
        }

        public void UserAddTitle()
        {
            System.Console.WriteLine("Enter the title of the movie: ");
        }

        public void UserAddGenre()
        {
            System.Console.WriteLine("Enter the genre of the movie: ");
        }
    }
}