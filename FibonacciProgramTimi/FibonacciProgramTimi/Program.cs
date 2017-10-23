// FibonacciProgramTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 30/05/2016
// Description: Printing out the fibonacci sequence
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciProgramTimi
{
    class Program
    {
        // Creating Variables
        static int number;
        static int fibonacci;
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            //UserInput
            number = int.Parse(Console.ReadLine());

            fibonacci = CalculatingFibonacci(number);

            string obo = number.ToString();
            //Outputting the sequencial number
            Console.WriteLine("The fibonnaci sequence for {0} is {1}", obo, fibonacci);
            Console.ReadLine();


        }
        //Creating the method
        static int CalculatingFibonacci(int number2)
        {

            // Calculating the number with the formula
            if (number2 == 0)

                return 1;
            if (number2 == 1)

                return 1;


            //Formula
            int calcFib = CalculatingFibonacci(number2 - 1) + CalculatingFibonacci(number2 - 2);

            return calcFib;
        }
    }
}