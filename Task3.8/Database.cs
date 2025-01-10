using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._8
{
    public class Database
    {

        public interface IFood
        {
            int OptionNumber { get; set; }
            string FoodTitle { get; set; }
            
        }
        public List<IFood> GetDB()
        {
            return new List<IFood>
           {
               new MenuItem(0, "Exit"),
               new MenuItem(1, "Pizza"),
               new MenuItem(2, "Burger")

           };

        }

        public class MenuItem : IFood
        {
            public int OptionNumber { get; set; }
            public string FoodTitle { get; set; }

            public MenuItem(int optionNumber, string foodTitle)
            {
                OptionNumber = optionNumber;
                FoodTitle = foodTitle;
            }

        }

    }
}
