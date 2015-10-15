using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVal = -1;

            bool repeat = true;
            {
                var r = new Random();
                Console.WriteLine("Can you guess the random number? It's 0-10, and you have 4 guesses");
                string guess = Console.ReadLine();
                numVal = Convert.ToInt32(guess);
                int a = numVal;
                Console.WriteLine("You Guessed: {0}", guess);
                Console.ReadLine();
                int x = r.Next(10);
                if (x == a)
                {
                    Console.WriteLine("You win! The number was {0}!", x);
                    Console.ReadLine();
                }
                else
                {
                    if (numVal > x)
                    {
                        Console.WriteLine("It's less than {0}", guess);
                    }
                    else if (numVal < x)
                    {
                        Console.WriteLine("It's more than {0}", guess);
                    }
                    Console.WriteLine("You have 3 guesses left!");
                    string guess2 = Console.ReadLine();
                    numVal = Convert.ToInt32(guess2);
                    int b = numVal;
                    Console.WriteLine("You Guessed: {0}", guess2);
                    Console.ReadLine();
                    if (x == b)
                    {
                        Console.WriteLine("You win! The number was {0}!", x);
                        Console.ReadLine();
                    }
                    else
                    {
                        if (numVal > x)
                        {
                            Console.WriteLine("It's less than {0}", guess2);
                        }
                        else if (numVal < x)
                        {
                            Console.WriteLine("It's more than {0}", guess2);
                        }
                        Console.WriteLine("You have 2 guesses left!");
                        string guess3 = Console.ReadLine();
                        numVal = Convert.ToInt32(guess3);
                        int c = numVal;
                        Console.WriteLine("You Guessed: {0}", guess3);
                        Console.ReadLine();
                        if (x == c)
                        {
                            Console.WriteLine("You win! The number was {0}!", x);
                            Console.ReadLine();
                        }
                        else
                        {
                            if (numVal > x)
                            {
                                Console.WriteLine("It's less than {0}", guess3);
                            }
                            else if (numVal < x)
                            {
                                Console.WriteLine("It's more than {0}", guess3);
                            }
                            Console.WriteLine("You have 1 guess left!");
                            string guess4 = Console.ReadLine();
                            numVal = Convert.ToInt32(guess4);
                            int d = numVal;
                            Console.WriteLine("You Guessed: {0}", guess4);
                            Console.ReadLine();
                            if (x == d)
                                {
                                    Console.WriteLine("You win! The number was {0}!", x);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("You lose, the number was {0}!", x);
                                    Console.ReadLine();
                                }
                        }
                    }
                    repeat = true;
                }
            }
        }
    }
}