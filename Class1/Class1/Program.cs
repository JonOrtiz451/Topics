using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            Teacher Tch = new Teacher();
            Whatever Whtvr = new Whatever();
            Game gme = new Game();
    
            bool flag = true;
            do
            {

                Console.WriteLine("SO much room for activites. Pick one:\n");
                Console.WriteLine("1: Calculate employee monthly income");
                Console.WriteLine("2: Have you passed or failed?");
                Console.WriteLine("3: Do the Multiplication!");
                Console.WriteLine("4: Great Divide!");
                Console.WriteLine("5: What number is thiccer?");
                Console.WriteLine("6: Are you odd or are we even?");
                Console.WriteLine("7: Extra Features");
                Console.WriteLine("8: F is for Factorial!");
                Console.WriteLine("9: Get with the Seasons");
                Console.WriteLine("10: Roshambo!");
                Console.WriteLine("11: Go away...Seriously there's nothing left.");
                int option = int.Parse(Console.ReadLine());


                switch (option)
                {

                    case 1:
                        Calc.Calcsal();
                        break;

                    case 2:
                        Tch.PassorFail();


                        break;
                    case 3:
                        Calc.Multiply();

                        break;
                    case 4:

                        Calc.Divide();


                        break;
                    case 5:

                        Tch.GreaterValue();

                        break;
                    case 6:
                        Tch.OddorEven();

                        break;
                    case 7:

                        Whtvr.extrafeatures();

                        break;
                    case 8:
                        gme.Factorial();
                        
                        
                        break;
                    case 9:
                        gme.GetSeason();
                        break;
                    case 10:
                        gme.Roshambo();
                        break;
                    case 11:
                        break;
                    default:
                        Console.WriteLine("These are not the options you are looking for", option);
                        flag = false;
                        break;
                }
            } while (flag);


        }
    }
}



