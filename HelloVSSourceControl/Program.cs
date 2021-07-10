using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVSSourceControl
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the show!");
            Console.WriteLine();

            DisplayInStockCars();

            Console.WriteLine();
            Console.WriteLine("Press a key to end");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of in stock cars, in alphabetical order.
        /// </summary>
        static void DisplayInStockCars()
        {
            // Not pulling from an actual database yet...
            List<string> inStockCars = new List<string>();
            inStockCars.Add("Honda Prelude - Qty: 5");
            inStockCars.Add("Kia Forte - Qty: 10");

            foreach (string currCar in inStockCars)
            {
                Console.WriteLine(currCar);
            }
        }
    }
}
