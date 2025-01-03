using System.ComponentModel.Design;
using System.Xml;

// Δημιουργήστε ένα interface με όνομα “IFood” το οποίο θα περιλαμβάνει ένα string property με όνομα “FoodTitle” και ένα int property
//  με όνομα “OptionNumber”. 
// Δημιουργήστε μία κλάση για το κάθε φαγητό του μενού, η οποία θα υλοποιεί το συγκεκριμένο interface.
// Αλλάξτε το array των επιλογών ώστε να περιέχει όλα αυτά τα αντικείμενα φαγητού, που υλοποιούν το interface “IFood”.
// Το array με τις επιλογές φαγητού πρέπει να έρχεται από άλλη κλάση, από μέθοδο που να λέγεται “GetMenuItems”.
// Αντικαταστήστε τις κλήσεις τις Int32.TryParse με Convert.ToInt32. Δεν πρέπει να υπάρχει πουθενά κλήση της Int32.TryParse 
// Φροντίστε, με το κατάλληλο error handling, η εφαρμογή να λειτουργεί κανονικά. Σε περίπτωση exception, να δείχνει ένα κατάλληλο 
// μήνυμα στον χρήστη και να μην έχει crash.  
// Η εφαρμογή πρέπει να μην τερματίζει, εκτός και αν ο χρήστης το επιλέξει. 

namespace Task1._16
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Menu initiation
            Menu menu = new Menu();

            //Responsible for stoping the execution  
            bool continueProgram = true;

            do
            {
                //Print menu
                menu.GetMenuItems();

                //Handle user input
                Console.WriteLine("Please type your selection: ");
                string userInput = Console.ReadLine();
                
                try
                {   
                    //Convert input and display choice
                    int intUserInput = Convert.ToInt32(userInput);
                    menu.Selection(intUserInput);

                    if (intUserInput == 0)
                    {
                        //Exit was selected by user
                        Console.WriteLine("Thank you, goodbye!");
                        continueProgram = false;
                    }
                }catch (Exception ex)
                {   
                    //Invalid input
                    Console.WriteLine($"An unexpected error occured: {ex.Message}");   
                }

            } while (continueProgram);
            
        }
    }
}
