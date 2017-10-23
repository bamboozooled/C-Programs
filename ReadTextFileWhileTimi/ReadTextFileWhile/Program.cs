// ReadTextFileWhileTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 30/03/2016
// Description: Learning to add a new namespace, use StreamReader and use While Loops
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();
            

            
        }
    }
}
