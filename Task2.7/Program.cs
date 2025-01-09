using System.Xml.Serialization;

// Δημιουργήστε ένα console application το οποίο θα δείχνει στον χρήστη μια λίστα από 10 τίτλους ταινιών με το rating τους 
//(πχ. από το IMDB: https://www.imdb.com/chart/top/?ref_=nv_mv_250 )
// Το app θα πρέπει να δείχνει τις παρακάτω επιλογές στον χρήστη:
// 1 - Δείξε μου τις 3 καλύτερες ταινίες
// 2 - Δείξε μου τις 3 χειρότερες ταινίες
// 3 - Δείξε μου όλες τις ταινίες με rating μεγαλύτερο ή ίσο του 9.0
// Θα πρέπει να χρησιμοποιηθούν generic collections και όχι arrays
// Error handling
// Interface implementations όπου χρειάζεται
// Επιλογή “0” (μηδέν) για έξοδο από το πρόγραμμα

namespace Task2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            Options opt = new Options();
            Input input = new Input();

            bool running = true;
            
            //Initialize db and options objects
            opt.InitializeOptions();
            db.IntializeDB();

            //Get movies from the database
            IEnumerable<IMovie> movies = db.GetMovies();

            while (running)
            {
                try
                {
                    opt.DisplayOptions();
                    Console.WriteLine("Please select a choice: ");

                    //Choice selection
                    int userInput = input.UserInput();

                    //Action based on choice
                    opt.SelectionResult(userInput, movies,out running);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured: {ex.Message}");
                }

            }


        }
    }
}
