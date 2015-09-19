using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNo = rnd.Next(1, 100);
            int Guess = 0;

            Console.WriteLine("Please try and guess a number between 1 and 100");
            
            while (Guess != randomNo)
            {
                string TempInt = Console.ReadLine();

                if (!Int32.TryParse(TempInt, out Guess))
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }

                Guess = Convert.ToInt32(TempInt);

                if( Guess < randomNo)
                {
                    Console.WriteLine("Please enter a higher number");
                }
                else if (Guess > randomNo)
                {
                    Console.WriteLine("Please enter a lower number");
                }          
            }

            Console.WriteLine("Well done! The answer was " + randomNo);
            Console.ReadLine();
        }
    }
}
