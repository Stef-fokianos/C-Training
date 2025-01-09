using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    class Input
    {
        public int UserInput()
        {
            //Get and validate that input is int 
            int userInput = -1;
            bool validInput = false;


            while (!validInput) 
            {
                Console.WriteLine("Enter your choice: ");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                
            }
            return userInput;
        }
    }
}
