using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVal = -1;
            bool repeat = true;

            while (repeat)
            {
                numVal = 0;
                Console.WriteLine("Enter a number of centimeters");

                string input = Console.ReadLine();
                try
                {
                    numVal = Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not only numbers. No letters or decimals please!");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("AN ERROR HAS OCCURED");
                }
                finally
                {
                    if (numVal < Int32.MaxValue)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The inputted {0} centimeters. The new value is {1} feet, or {2} inches", numVal, numVal * 0.0328084, numVal * 0.3937008);
                        Console.ReadLine();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("AN ERROR HAS OCCURED");
                        Console.ReadLine();
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
