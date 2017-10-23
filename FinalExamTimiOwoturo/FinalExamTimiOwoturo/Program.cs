//ProgramName: FinalExamTimiOwoturo
//Name: Timi Owoturo
//Teachers Name: Miss Lishynski
//Date: 13/10/2016
//Description: A program which calculates the grand total of a users purchases. It asks for the total ammount, applies a shipping charge and calculates tax
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamTimiOwoturo
{
    class Program
    {
        // creating variable
        static double shipping;
        static double n = Convert.ToDouble(13) / Convert.ToDouble(100);
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Enter the total value for your purchases");
            string totalValue = Console.ReadLine();
            double newTotalValue = double.Parse(totalValue);
            Console.WriteLine("How many items did you purchase?");
            string totalPurchases = Console.ReadLine();
            int newTotalPurchases = int.Parse(totalPurchases);
            //Calculating tax
            double tax = Convert.ToDouble(13) / Convert.ToDouble(100) * newTotalValue;
            double calculatingSalesTax = (Convert.ToDouble(13) / Convert.ToDouble(100) * newTotalValue) + newTotalValue;

            
            
            //If statements calculating shipment
            if (newTotalPurchases < 3 && newTotalPurchases != 0)
            {
                shipping = 3.50;
            }

            else if (newTotalPurchases >= 3 && newTotalPurchases <= 6)
            {
                shipping = 5.00;
            }

            else if (newTotalPurchases >= 7 && newTotalPurchases <= 10)
            {
                shipping = 7.00;
            }
            else if (newTotalPurchases >= 11 && newTotalPurchases <= 15)
            {
                shipping = 9.00;
            }
            else if (newTotalPurchases > 15)
            {
                shipping = 10.00;
            }
            else if (newTotalPurchases < 1)
            {
                shipping = 0.00;
                Console.WriteLine("You cannot have a total purchase of 0, restart the program again please");
            }
            // Calculating Grand total
            double overallTotal = calculatingSalesTax + shipping;
            // outputting the itemized summary. 
            Console.WriteLine("Your total Purchase charge is : {0:C2}", newTotalValue);
            Console.WriteLine("Number of items purchased : {0}", newTotalPurchases);
            Console.WriteLine("tax ammount: {0:C2}", tax);
            Console.WriteLine("shipping charge: {0:C2}", shipping);
            Console.WriteLine("grand total: {0:C2}", overallTotal);

            Console.ReadLine();
        }
    }
}
