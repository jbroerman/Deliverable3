/* Jacob Broerman
 * 1/31/23
 * Description: Create a user input with a for loop and try/catch that takes an integer between 1-100 and creates an odd/even sequence.
 */


using System;

namespace Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input;
            string series;

            Console.WriteLine("Enter an integer value between 1 and 100: ");

            try
            {
                Input = int.Parse(Console.ReadLine());

                if (Input < 1 || Input > 100)
                {
                    throw new Exception();
                }

                Console.WriteLine("Choose a series: (even/odd)");
                series = Console.ReadLine();

                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + Input + " are:");

                if (series == "even")
                {
                    for (int i = 0; i <= Input; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (series == "odd")
                {
                    for (int i = 1; i <= Input; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid series type.");
                }
            }
            
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer value between 1 and 100.");
            }
        }
    }
}