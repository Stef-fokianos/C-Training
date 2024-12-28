using System.Net.Sockets;

namespace Task1._12
{
    public class Menu
    {
        private string[] options = { "1. Pizza", "2. Burger", "0. Exit" };

        public void DisplayMenu()
        //Diplay Menu options
        {
            Console.WriteLine("Please pick a choice: ");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

        }

        public void Selection(string userInput)
        //Output based on choice
        {
            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Your selection is Pizza.");
                    break;
                case "2":
                    Console.WriteLine("Your selection is Burger.");
                    break;
                case "0":
                    Console.WriteLine("Exiting application.");
                    break;
                default:
                    Console.WriteLine("Wrong selection!");
                    break;
            }
        }

    }
}
