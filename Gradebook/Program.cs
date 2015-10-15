using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVal = -1;
            int x;
            int GradeOne = 0;
            int GradeTwo = 0;
            int GradeThree = 0;
            int GradeFour = 0;
            int GradeFive = 0;
            int GradeSix = 0;
            int GradeSeven = 0;
            int GradeEight = 0;
            int GradeNine = 0;
            int GradeTen = 0;
            int testsTaken2;
            int Mean1 = 0;
            int Mean2 = 0;
            Console.WriteLine("Enter the name of the student.");
            string name = Console.ReadLine();
            Console.WriteLine("How many tests have been taken? (max: 10)");
            string testsTaken = Console.ReadLine();
            numVal = Convert.ToInt32(testsTaken);
            if (numVal > 10)
            {
                numVal = 10;
            }
            testsTaken2 = numVal;
            x = 0 - numVal;
            Console.WriteLine("Number of tests taken: {0}", numVal);
            do
            {

                Console.WriteLine("Please enter a test score");
                if (x == -10)
                {
                    string gradeOne = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeOne);
                    GradeOne = numVal;
                }
                else if (x == -9)
                {
                    string gradeTwo = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeTwo);
                    GradeTwo = numVal;
                }
                else if (x == -8)
                {
                    string gradeThree = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeThree);
                    GradeThree = numVal;
                }
                else if (x == -7)
                {
                    string gradeFour = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeFour);
                    GradeFour = numVal;
                }
                else if (x == -6)
                {
                    string gradeFive = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeFive);
                    GradeFive = numVal;
                }
                else if (x == -5)
                {
                    string gradeSix = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeSix);
                    GradeSix = numVal;
                }
                else if (x == -4)
                {
                    string gradeSeven = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeSeven);
                    GradeSeven = numVal;
                }
                else if (x == -3)
                {
                    string gradeEight = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeEight);
                    GradeEight = numVal;
                }
                else if (x == -2)
                {
                    string gradeNine = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeNine);
                    GradeNine = numVal;
                }
                else if (x == -1)
                {
                    string gradeTen = Console.ReadLine();
                    numVal = Convert.ToInt32(gradeTen);
                    GradeTen = numVal;
                }

                x++;
            } while (x < 0);
            Mean1 = GradeOne + GradeTwo + GradeThree + GradeFour + GradeFive + GradeSix + GradeSeven + GradeEight + GradeNine + GradeTen;
            Mean2 = Mean1 / testsTaken2;
            Console.WriteLine(name);
            Console.WriteLine("Mean of tests taken: {0}", Mean2);
            if (Mean2 < 70)
            {
                Console.WriteLine("Letter grade: F");
                Console.ReadLine();
            }
            else if (Mean2 > 69)
            {
                if (Mean2 < 75)
                {
                    Console.WriteLine("Letter grade: D");
                    Console.ReadLine();
                }
                else if (Mean2 > 74)
                {
                    if (Mean2 < 80)
                    {
                        Console.WriteLine("Letter grade: C");
                        Console.ReadLine();
                    }
                    else if (Mean2 > 79)
                    {
                        if (Mean2 < 90)
                        {
                            Console.WriteLine("Letter grade: B");
                            Console.ReadLine();
                        }
                        else if (Mean2 > 89)
                        {
                            Console.WriteLine("Letter grade: A");
                            Console.ReadLine();
                        }
                    }
                }



            }
        }
    }
}
