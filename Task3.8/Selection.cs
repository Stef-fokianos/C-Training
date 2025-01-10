using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Task3._8
{
    public class Selection
    {
        public static async Task<string> ActionOfInput(List<Database.IFood> options, string userInput)
        {

            if (userInput == "0")
            {
                // Exit was selected by user
                ProgramState.ContinueProgram = false;
                return "Thank you, goodbye!";
            }

            try
            {
                var cts = new CancellationTokenSource();

                if (userInput.ToLower() == "cancel")
                {
                    cts.Cancel();
                    return "Meal preparation canceled.";
                }

                int intUserInput = Convert.ToInt32(userInput);
                

                foreach (var option in options)
                {
                    if (intUserInput == option.OptionNumber)
                    {
                        // Valid input found
                        string selection = option.FoodTitle;



                        // Start meal preparation
                        var preparationTask = Meal.PrepareMealAsync(selection);

                        // Wait for meal
                        string result = await preparationTask;

                        return result;
    
                    }
                }
                //Invalid input
                return "Please enter a valid menu choice.";
            }
            catch (Exception ex)
            {
                //Invalid input
                Console.WriteLine($"Error: {ex.Message}");
                return "Please enter a valid menu choice.";
            }
        }

    }
}
