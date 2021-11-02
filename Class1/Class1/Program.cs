using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            do
            {

                Console.WriteLine("SO much room for activites. Pick one:\n");
                Console.WriteLine("1: Click ME! I'm the most fun!");
                Console.WriteLine("2: Have you passed or failed? <= Please don't click");
                Console.WriteLine("3: Do the Multiplication!");
                Console.WriteLine("4: Great Divide!");
                Console.WriteLine("5: What number is thiccer?");
                Console.WriteLine("6: Are you odd or are we even?");
                Console.WriteLine("7: Extra Features");
                Console.WriteLine("8: Go away...Seriously there's nothing left.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Random rnd = new Random();
                        Console.WriteLine("Don't know why you're here but, pick a number to fight this troll. ", option);
                        Console.WriteLine("Deal the right amount of damage to kill the troll.");
                        Console.WriteLine("He's only level one so his HP is around 1 to 10.");
                        Console.WriteLine("Let's say you have three attempts. Here's a sword.  Good luck, don't die.");
                        Console.WriteLine("Hit enter to begin: ");
                        Console.ReadKey();
                        int randomNumber = rnd.Next(1, 10);
                        Console.Write("Attack : ");
                        for (int z = 0; z < 3; z++)
                        {
                            int attack = Convert.ToInt32(Console.ReadLine());
                            if (attack == randomNumber && z < 3)
                            {
                                Console.WriteLine("Yay! He's dead. and now you're a murderer. Good luck living with that. ", randomNumber);
                            }
                            else if (z == 2)
                            {
                                Console.WriteLine("Well now you're dead. Seems alot like a you problem.");
                            }
                            else
                            {
                                Console.WriteLine("Miss");
                            }
                            Console.WriteLine(" continue? ");
                        }break;
                    
                    case 2:
                        Console.WriteLine(" Yeah so my code decided to dissappear....crap\n");


                        break;
                    case 3:
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

                        break;
                    case 4:
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


                        break;
                    case 5:
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

                        break;
                    case 6:
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

                        break;
                    case 7:
                        Console.WriteLine("Yeah there's only one feature. Find out if a number is a prime.");
                        Console.WriteLine("No. not like Optimus...Trust me. I thought it was too at first.");
                        int a4;
                        Console.WriteLine("Input a prime number");
                       a4 = Convert.ToInt32(Console.ReadLine());
                       if (a4 % 2 ==0)
                        {
                            Console.WriteLine(" Yeah. not a prime. He's with Megatron.");
                            
                        }
                        else
                        {
                            Console.WriteLine(" Is a prime number. Optimus is that you?");
                        }
                        break;

                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("These are not the options you are looking for", option);
                        
                        break;
                }
            } while (flag);
        }
    }
}



