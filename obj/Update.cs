namespace A11_Convert
{
    public class Update
    {
        public void UpdateMovie()
        {
           Menu menu = new Menu();
           MovieContext db = new MovieContext();

           System.Console.WriteLine("What movie would you like to update?(Enter movie ID): "); 
           var movieId = System.Console.ReadLine();

           var fixTitle = db.Movies.First(db => db.Id == movieIdDel);
           System.Console.WriteLine("Enter the updted title: ");
           var newTitle = System.Console.ReadLine();
           fixTitle.Title = newTitle;
           db.SaveChanges();
        }
    }
}