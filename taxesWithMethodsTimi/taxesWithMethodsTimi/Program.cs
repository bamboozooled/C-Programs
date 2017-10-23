// taxesWithMethodsTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 08/04/2016
// Description: Outputting the address and new property value. Making calculations for the tax.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxesWithMethodsTimi
{
    class Program
    {
        // Creating/Declaring the Global variables
        static string propAddress;
        static decimal propValue;
        static decimal propValueNew;
        static double propTaxes;
        static decimal propValueInput;
        static void Main(string[] args)
        {
            // Assigning some of the Global Variables with their parameters
            Console.WriteLine("Enter your property address and Value");
            propAddress = propAdd("Enter your property Address!");
            Console.WriteLine("What is your property value?");
            propValueInput = decimal.Parse(Console.ReadLine());
            propValue = propVal(propValueInput);
            propTaxes = taxes(Convert.ToDouble(propValueNew));
            output(propAddress, propTaxes);
            Console.ReadLine();
        }
        // Address Method
        static string propAdd (string propAdd2)
        {
            string value;
            Console.WriteLine(propAdd2);
            value = Console.ReadLine();
            return value;
        }

        // Property Value method with New property Values using calculations 
        static decimal propVal (decimal propValueInput)
        {
            propValueNew = (Convert.ToDecimal(0.027) * propValueInput) + propValueInput;
            
            return propValueNew;
           }
        // Calculating Property Taxes in the Propery Tax method
        static double taxes (double propValueNew)
        {

            double NewValueAfterSub; 
            NewValueAfterSub = Convert.ToDouble(propValueNew) - 25000;
            double propTaxes2;
            propTaxes2 = (NewValueAfterSub / 1000) * 10.03;

            return propTaxes2;
        }
        // Outputting the values for property Adress and Property tax
        static void output(string propAddress, double propTaxes)
        {
            Console.WriteLine("Your Address is {0}, your property tax is {1:C}", propAddress, propTaxes);
        }
    }
}
