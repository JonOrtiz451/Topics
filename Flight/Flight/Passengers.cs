using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{

    public class Passengers
    {
  
        public static void Passenger()
        {
            string reservation;
            string name;

            Console.WriteLine("What is your name?\n");
            name = Console.ReadLine();
            Console.WriteLine(name + " Do you have a reservation? Y/N\n");
            reservation = Console.ReadLine();
            if (reservation == "Y")
            {
                Console.WriteLine(" Your spot is reserved and you will not lose your seat.\n");
            }
            else if (reservation == "N")
            {
                Console.WriteLine("You do not have a reservation, do not be upset if there is not a seat available to you.\n");
            }
        }


    }
}
