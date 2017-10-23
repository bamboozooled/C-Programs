// AkermanFunctionProgramTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 13/06/2016
// Description: Creating the Akerman Function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkermanFunctionProgramTimi
{
    class Program
    {
        // Creating Variables
        static int m1;
        static int n1;
        static int ans;
        static int Ack;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter M");
            // User Input
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N");
            //User Input
            n1 = int.Parse(Console.ReadLine());
            // Calling the method/Using Parameters
            int Ack = Ackermann(m1, n1);

            //outputting the answer
            Console.WriteLine("The answer is: ({0})", Ack);

            Console.ReadLine();
            
        }

        //Creating Method with parameters
        static int Ackermann(int m2, int n2)
        {
            if (m2 == 0)

                // returning the answer/value
                return ans = n2 + 1;

            else if (m2 > 0 && n2 == 0)
            
                return ans = Ackermann(m2 - 1, 1);
            else 
            
                return ans = Ackermann(m2 - 1, Ackermann(m2, n2 - 1));
            

               
        }
    }
}
