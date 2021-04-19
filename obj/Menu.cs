using System;

namespace A11_Convert
{
    public class Menu
    {
        public Menu()
        {
            DisplayMenu();
        }
        private void DisplayMenu()
        {
            Console.WriteLine("1. Search Movies");
            Console.WriteLine("2. Add Movie");
            Console.WriteLine("3. Update Movie");
            Console.WriteLine("4. Delete Movie");
            var choice = System.Console.ReadLine();
        }

        public void UserSelection()
        {
            switch (choice)
            {
                case '1':
                Search search = new Search();
                search.SearchMovies();
                break;
                case '2':
                Add add = new Add();
                add.AddMovie();
                break;
                case '3':
                Update update = new Update();
                update.UpdateMovie();
                break;
                case '4':
                Delete delete = new Delete();
                delete.DeleteMovie();
                break;
            }
        }
    }
}