using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task2._7
{
    class Options
    {
        public int OptionNum { get; set; }
        public string Description { get; set; }

        private List<Options> optionsList = new List<Options>();

        public Options() 
        {
            //Used to get an Options object 
        }

        public Options(int num, string description)
        //Data fields for movies 
        {
            OptionNum = num;
            Description = description;
        }

       
        public void InitializeOptions()
        {
            //Options list
            optionsList.AddRange(new List<Options>
            {
                new Options(0, "Exit Application"),
                new Options(1, "Best 3 movies"),
                new Options(2, "Worst 3 movies"),
                new Options(3, "Movies with rating 9 and above"),
            });
        }

        public void DisplayOptions()
        {
            //Display all options
            Console.WriteLine("Available options:");

            foreach (var opt in optionsList)
            {
                Console.WriteLine($"{opt.OptionNum} - {opt.Description}");
            }
        }

        public void GetTop3(IEnumerable<IMovie> movies)
        {
            //Used to get 3 top rated movies from db 
            var top3 = movies.OrderByDescending(movies => movies.Rating).Take(3).ToList();

            Console.WriteLine("Top 3 Movies: \n");

            foreach (var movie in top3)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }
            Console.WriteLine("\n");
        }

        public void GetWorst3(IEnumerable<IMovie> movies)
        {
            //Used to get 3 worst rated movies from db 
            var worst3 = movies.OrderBy(movies => movies.Rating).Take(3).ToList();

            Console.WriteLine("Worst 3 Movies: \n");

            foreach (var movie in worst3)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }
            Console.WriteLine("\n");
        }

        public void Get9AndAbove(IEnumerable<IMovie> movies)
        {
            //Used to get all movies with rating 9 and above from db 
            var above9 = movies.Where(movies => movies.Rating >= 9).ToList();

            Console.WriteLine("Movies with rating 9 and above: \n");

            foreach (var movie in above9)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }
            Console.WriteLine("\n");
        }

        public void Exit(ref bool running)
        {
            //Used to exit program
            running = false;
            Console.WriteLine("Thank you! Goodbye.");

        }

        public bool SelectionResult(int userInput, IEnumerable<IMovie> movies, out bool running)
        {
            //Options and corensponding actions
            running = true;
            switch (userInput)
            {
                case 1:
                    GetTop3(movies);
                    return running;

                case 2:
                    GetWorst3(movies);
                     return running;

                case 3:
                    Get9AndAbove(movies);
                    return running;

                case 0:
                    Exit(ref running);
                    return running;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    return running;

            }
        }

    }
}

