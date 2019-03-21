using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace what_is_your_favorite_color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite color? ");
            string favoriteColor = Console.ReadLine();

            if (favoriteColor == "red")
            {
                Console.WriteLine("Red is sweet");
            }
            else if (favoriteColor == "blue")
            {
                Console.WriteLine("Blue is wet");
            }
            else if (favoriteColor == "yellow")
            {
                Console.WriteLine("Yellow is ugly");
            }
            else
            {
                Console.WriteLine("Fun color.");
            }
            Console.ReadLine();
            /*
           If the user has entered "red" then: "Red is sweet"
           If the user has entered "blue" then it shows: "Blue is wet"
           If the user entered "yellow" then it shows: "Yellow is ugly"
           If the user has entered another color, it shows: "Fun color."
           */
        }
    }
}
