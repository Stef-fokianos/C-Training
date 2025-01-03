using System.Net.Sockets;

namespace Task1._16
{
    public class Menu
    {   
        //Choices initiation 
        private IFood exit = new Exit();
        private IFood pizza = new Pizza();
        private IFood burger = new Burger();
        private IFood[] options;

        public Menu()
        { 
            //Menu options to include 
            options = new IFood[] {pizza, burger, exit};
        }


        public void GetMenuItems()
        //Display Menu options
        {
            Console.WriteLine("Menu:");
            foreach (IFood option in options)
            {
                Console.WriteLine($"{option.OptionNumber} : {option.FoodTitle}");
            }

        }

        public void Selection(int userInput)
        //Output based on choice
        {
            int intUserInput = Convert.ToInt32(userInput);

            bool found = false;
            //Display selected choice
            foreach (IFood option in options)
            {
                if (intUserInput == option.OptionNumber)
                {
                    Console.WriteLine($"You selected: {option.FoodTitle}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Please enter a valid menu choice.");
            }
           
        }

        public interface IFood 
        {
            string FoodTitle {  get; set; }
            int OptionNumber { get; set; }
        }

        public class Exit : IFood
        {
            public int OptionNumber { get; set; } = 0;
            public string FoodTitle { get; set; } = "Exit";
        }

        public class Pizza : IFood
        {
            public int OptionNumber { get; set; } = 1;
            public string FoodTitle { get; set; } = "Pizza";
        }

        public class Burger : IFood
        {
            public int OptionNumber { get; set; } = 2;
            public string FoodTitle { get; set; } = "Burger";
        }

       
    }
}
