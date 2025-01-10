using System.Net.WebSockets;

// Τροποποιήστε την εφαρμογή φαγητού ως εξής:
// Όταν ο χρήστης επιλέγει ένα φαγητό, η εφαρμογή πρέπει να το “προετοιμάσει”. Οπότε και θα πρέπει να περάσει ένα διάστημα μέχρι να βγάλει 
// το μήνυμα “Your {selection} is ready.” (όπου {selection} το επιλεγμένο από τον χρήστη φαγητό). Αυτό το διάστημα ορίστε το στα 10 δευτερόλεπτα.
// Μέχρι την προετοιμασία του φαγητού, ο χρήστης θα έχει τη δυνατότητα να ακυρώσει την προετοιμασία, πληκτρολογώντας τη λέξη “cancel”.
// Σε περίπτωση που ο χρήστης ακυρώσει την παραγγελία του, η εφαρμογή θα πρέπει να δείξει το κατάλληλο μήνυμα και μετά να ξαναδείξει το μενού στον χρήστη.

namespace Task3._8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Menu menu = new Menu();
            Database db = new Database();  

            List<Database.IFood> options = db.GetDB();
            
            CancellationTokenSource cts = new CancellationTokenSource();
            
            while (ProgramState.ContinueProgram)
            {

                //Print menu
                menu.GetMenuItems(options);

                //Get user input
                Console.WriteLine("Please type your selection: ");

                string userInput = Console.ReadLine();

                // Process selection
                var result = await Selection.ActionOfInput(options, userInput);

                Console.WriteLine(result);

            }

        }

       

    }
}
