using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task3._8.Database;

namespace Task3._8
{
    public class Menu
    {
        public void GetMenuItems(List<Database.IFood> options)
        //Display Menu options
        {
            Console.WriteLine("Menu:");
            foreach (var option in options)
            {
                Console.WriteLine($"{option.OptionNumber} : {option.FoodTitle}");
            }

        }
    }
}
