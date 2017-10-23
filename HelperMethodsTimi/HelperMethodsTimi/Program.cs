//************************************************************************************************************************
// HelperMethodsTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski 
// Date: 23/03/2016
// Description: Teaching us how to use methods
//*********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethodsTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = superSecretFormula();

            string myValue = superSecretFormula("Bob");
            // Printing out myValue
            Console.WriteLine(myValue);

            //Printing out the method value (return)
            Console.WriteLine(superSecretFormula());

            Console.ReadLine();
        }
        // Creating the method
        private static string superSecretFormula()
        {
            return "Hello World";
        }
        //Creating the method( There is an overload)
        private static string superSecretFormula(string name)
        {
            return String.Format("Hello World, {0}", name);
        }

    }
}
