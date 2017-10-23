// ProfitProgramTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 10/06/2016
// Description: Using If statements to calculate the profit for a certain amount of sales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitProgramTimi
{
    class Program
    {
        //Creating Variables
        static int sales;
        static int sales2;
        static void Main(string[] args)
        {
            // Prompting the user.
            Console.WriteLine("Enter a sales value so we can calculate your profit");
            //User Input
            sales = int.Parse(Console.ReadLine());
            //If statements
            if (sales >= 0 && sales <= 1000)
            {   // Outputting the sales and profit
                Console.WriteLine("Your sales is {0:C2} and your profit is {1:C2}, Using a rate of 3.0%", sales, (3.0 / 100 * sales));
            }

            else if (sales > 1000 && sales <= 5000)
            {
                Console.WriteLine("Your sales is {0:C2} and your profit is {1:C2}, Using a rate of 3.5%", sales, (3.5 / 100 * sales));
            }

            else if ( sales > 5000 && sales <= 10000)
            {
                Console.WriteLine("Your sales is {0:C2} and your profit is {1:C2}, Using a rate of 4.0%", sales, (4.0 / 100 * sales));
            }

            else if (sales >= 10000)
            {
                Console.WriteLine("Your sales is {0:C2} and your profit is {1:C2}, Using a rate of 4.5%", sales, (4.5 / 100 * sales));
            }

            else
            {
                Console.WriteLine("You cannot have negative sales, and there is no case for this. Thanks for using the program");
            }
            Console.ReadLine();
                
        }

        
        
           
    }

}
