using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
   public class FlightData
    {
        public static void flightdata()
        {
            Random rand = new Random();
            int seats;
            string origin;
            string arrival;
            string seatsavail;
            int passengers;

            Console.WriteLine("Where are you departing from?\n");
            origin = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You are departing from " + origin + ".");

            Console.WriteLine("Where is your arrival destination? \n");
            arrival = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Would you like to see how many seats are available? Y/N \n");
            seatsavail = Console.ReadLine();
            if (seatsavail == "Y")
            {
                passengers = rand.Next(10, 25);
                seats = rand.Next(5, 12);
                Console.WriteLine("There are " + seats + " seats available. And currently " + passengers + " seats reserved for this flight.\n");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please press enter to view your estimated arrival time: \n");
                Console.BackgroundColor = ConsoleColor.Black;

            }
            else
            {
                Console.WriteLine("If you do not have a reservation you are not guaranteed a seat.\n");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please press enter to view your estimated arrival time: \n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.ReadKey();





            Console.WriteLine("Your departure is from " + origin + ". Your destination is  " + arrival+ " and you will be expected to arrive in " + rand.Next(1, 5) + " hour(s)" + " and " + rand.Next(2, 59) + " minutes.\n");
        }
    }
}
