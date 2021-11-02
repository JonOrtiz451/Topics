using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Calculator
    {
        public void Multiply()
        {
            try
            {


            Console.WriteLine("We do big boi math here!");

            double a;
            double b;
            double result;
            Console.WriteLine("Input your first number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number");
            b = double.Parse(Console.ReadLine());
            result = a * b;
            Console.WriteLine("This is the answer = " + result);
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Divide()
        {
            try
            {


            Console.WriteLine("Division is cool...I guess");
            int a1;
            int b1;
            double result2;
            Console.WriteLine("Input your first number");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number");
            b1 = Convert.ToInt32(Console.ReadLine());
            result2 = a1 / b1;
            Console.WriteLine("This is the answer = " + result2);
            if (result2 == 0)
            {
                Console.WriteLine("0 is not an acceptable number");
            }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }
        public void Calcsal()
        {
            try
            {



                Console.WriteLine("What is the employees name?");
                String name;
                double hrwage;
                double hrwork;
                double totalpay;
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();
                Console.WriteLine("What is your hourly wage? ");
                hrwage = double.Parse(Console.ReadLine());
                Console.WriteLine("How many hours did you work this month? ");
                hrwork = double.Parse(Console.ReadLine());
                totalpay = hrwage * hrwork * 4;
                Console.WriteLine(name + " Has earned a total of " + totalpay + " this month");
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
