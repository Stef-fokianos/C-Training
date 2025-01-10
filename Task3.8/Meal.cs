using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._8
{
    public class Meal
    {
        //All meal preparations are 10sec curently =10000ms
        private static int preparationTime = 10000;
        

        public static async Task<string> PrepareMealAsync(string selection)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            Console.WriteLine("Your meal is now being prepared.");

            string cancelMessage = "Type 'cancel' to stop meal preparation.";

            // Start listening for the cancel input in a background task
            var cancelTask = Task.Run(() => ListenForCancel(cts));

            try
            {
                int preparationTimeInSeconds = preparationTime / 10;

                for (int i = 0; i < 10; i++) 
                {
                    if (cts.Token.IsCancellationRequested)
                    {
                        throw new OperationCanceledException();
                    }
                    await Task.Delay(preparationTimeInSeconds);
                }
            }
            catch (OperationCanceledException)
            {
                return "Meal preparation was canceled.";
            }
            return $"Your {selection} is ready.";

        }
    
        private static void ListenForCancel(CancellationTokenSource cts)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "cancel")
                    {
                        cts.Cancel();
                        break;
                    }
                }
            }
        }
    
    }
}


