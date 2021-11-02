using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Whatever
    {
        public void extrafeatures()
        {
            Console.WriteLine("Here are the extra features \n");
            Console.WriteLine("1: Click on this one! It's the most fun");
            Console.WriteLine("2: Find the prime number");
            int option2 = int.Parse(Console.ReadLine());
            switch (option2)
            {

                case 1:
                    try
                    {
                        Console.WriteLine("Hit enter:");
                        Random rnd = new Random();
                        Console.WriteLine("Don't know why you're here but, pick a number to fight this troll. ");
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
                        }
                    }
                    catch (Exception e)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }


                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Yeah there's only one feature. Find out if a number is a prime.");
                        Console.WriteLine("No. not like Optimus...Trust me. I thought it was too at first.");
                        int a4;
                        Console.WriteLine("Input a prime number");
                        a4 = Convert.ToInt32(Console.ReadLine());
                    
                        if (a4 % 2 == 0)
                        {
                            Console.WriteLine(" Yeah. not a prime. He's with Megatron.");

                        }
                        else
                        {
                            Console.WriteLine(" Is a prime number. Optimus is that you?");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Invalid Option. You will now return to the main menu.\n", Console.BackgroundColor);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
   
                    break;

                

                    




                    



            }

        }
    }
}
