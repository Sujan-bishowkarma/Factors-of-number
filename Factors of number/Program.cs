using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables.
            int num;
            int i;

            // Get the value from user. 
            Console.WriteLine("Please enter any number");
            num = Convert.ToInt32(Console.ReadLine());

            // Dispay the multiple of number.
            Console.WriteLine("The factor of the number {0} are", num);
            

            // Using for loop.
            for(i = 1; i <= num; i++)
            {
                // checking the factor of entered number.
                if (num % i == 0) 

                    Console.WriteLine("{0}", i); // Display the result

            }
            Console.ReadKey();
            
        }
    }

}
