using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Teacher
    {
        public void PassorFail()
        {
            try
            {
                double grd = 0;

                Console.WriteLine("Enter your first grade: ");
                grd = double.Parse(Console.ReadLine());

                if (grd < 70)
                {
                    Console.WriteLine("You are failing!");
                }
                else
                {
                    Console.WriteLine("Congratulations you passed!");
                }
            }

            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                Console.BackgroundColor = ConsoleColor.Black;
            }


        }

        public void GreaterValue() 
        {

            try
            {



                Console.WriteLine("Why. Why did you click on this one?");
                int a2;
                int b2;
                bool value1;
                bool value2;
                Console.WriteLine("Enter first number");
                a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b2 = Convert.ToInt32(Console.ReadLine());
                value1 = a2 > b2;
                value2 = b2 > a2;
                if (value1)
                {
                    Console.WriteLine(a2 + " is a thiccer boi");
                }
                if (value2)
                {
                    Console.WriteLine(b2 + " is a thiccer boi");
                }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void OddorEven() 
        {
            try
            {


                Console.WriteLine("Alright. You came here to find out if you're weird? Well too bad. It's about numbers.");
                int a3;
                Console.WriteLine("Input a number");
                a3 = int.Parse(Console.ReadLine());

                if (a3 % 2 == 0)
                {
                    Console.WriteLine("And now we're even number");
                }
                else
                {
                    Console.WriteLine("That number is a bit odd");
                }
                Console.WriteLine("Input a number");
                a3 = int.Parse(Console.ReadLine());
                if (a3 % 2 == 0)
                {
                    Console.WriteLine("And now we're even.");
                }
                else
                {
                    Console.WriteLine("That number is a bit odd");
                }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                Console.BackgroundColor = ConsoleColor.Black;

            }



        }

    }
 
  
}

