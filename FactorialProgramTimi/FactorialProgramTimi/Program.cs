// FactorialProgramTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 30/05/2016
// Description: Calculating factorial for a number the user types in
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgramTimi
{
    class Program
    {
        static int number;
        static int factorial;
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to calculate its factorial");
            //UserValue and Input
            number = int.Parse(Console.ReadLine());

            factorial = CalculatingFactorial(number);

            string obo = number.ToString();
            //Outputting the final answer
            Console.WriteLine("The Factorial of {0}, is equal to {1}", obo, factorial);
            Console.ReadLine();
            
            
        }
        // Creating the method
        static int CalculatingFactorial (int number2)
        {
            //Calculating the factorial with the formula

            if (number2 == 0)

                return 1;

            else

               
            return (number2) * CalculatingFactorial(number2 - 1);
        }
    }
}
