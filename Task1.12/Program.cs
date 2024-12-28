using System.ComponentModel.Design;

// Δημιουργήστε ένα Console Application το οποίο θα δείχνει στον χρήστη ένα μενού με τουλάχιστον 2 επιλογές 
// φαγητού και μία επιλογή για έξοδο από το πρόγραμμα, η οποία θα έχει τιμή “0” (μηδέν) και θα είναι τελευταία στη λίστα.
//  Όταν ο χρήστης επιλέγει κάποια από τις επιλογές, το Application πρέπει να δείχνει στην κονσόλα ποιο φαγητό επέλεξε 
//  και μετά απλά να τερματίζει.
// Υποχρεωτικά specs:
// Οι επιλογές που θα δείχνει το Application, πρέπει να είναι αποθηκευμένες σε ένα Array.
// Οι επιλογές πρέπει να προβάλλονται στην κονσόλα με κάποιο loop.
// Σε περίπτωση που ο χρήστης δεν επιλέξει κάποια επιλογή από το μενού, αλλά ούτε και “Έξοδο” από το application, το application πρέπει να δείξει το μήνυμα “Wrong selection!” και να τερματίζει.

namespace Task1._12
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Menu initiation and display 
            Menu menu = new Menu();
            menu.DisplayMenu();

            //Handle user input
            Console.WriteLine("Please type your selection: ");
            string userInput = Console.ReadLine();
            menu.Selection(userInput);

        }
    }
}
