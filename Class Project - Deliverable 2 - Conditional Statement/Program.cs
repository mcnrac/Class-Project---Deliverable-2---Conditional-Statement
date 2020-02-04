using System;

namespace Class_Project___Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            {//Ask user to enetr what numeric value (grade) they think they will get
                Console.WriteLine("Please enter a grade you anticipate to get");

                //Allow user to unput expected grade
                string input = Console.ReadLine();

                //This will read the input of the user
                int grade = int.Parse(input);

                //Negative integer entered
                if (grade < 0)
                {
                    Console.WriteLine("You must enter a grade greater than 0");
                }
                //if the user enters negative integer
                else if (grade > 100)
                {
                    Console.WriteLine("You need to enter a grade below 100");
                }
                else if (grade >= 98)
                {
                    Console.WriteLine("Your Grade is an A+");
                }
                else if (grade >= 92)
                {
                    Console.WriteLine("Your Letter Grade is A");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("Your Letter Grade is A-");
                }
                else if (grade >= 88)
                {
                    Console.WriteLine("Your Letter Grade is B+");
                }
                else if (grade >= 82)
                {
                    Console.WriteLine("Your Letter Grade is B");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your Letter Grade is B-");
                }
                else if (grade >= 78)
                {
                    Console.WriteLine("Your Letter Grade is C+");
                }
                else if (grade >= 72)
                {
                    Console.WriteLine("Your Letter Grade is C");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your Letter Grade is C-");
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("Your Letter Grade is D+");
                }
                else if (grade >= 62)
                {
                    Console.WriteLine("Your Letter Grade is D");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your Letter Grade is D-");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your Letter Grade is F");
                }
                
                
            }
        }
    }
}
