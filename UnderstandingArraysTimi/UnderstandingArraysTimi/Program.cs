// Understanding Arrays
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 10/03/2016
// Description: The array program on video 09. Creating arrays and learning new ways to handle them by using char, Console.Write.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArraysTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            ////numbers[5] = 42;

            int[] numbers = { 4, 18, 15, 16, 23 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string[] names = { "Bob", "Steve", "Brian", "Chuck"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string myText = "Now is the time for all good men to come to  the aid of their country";
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);

            foreach (char myChar in charArray)
            {
                Console.Write(myChar);
            }
            //Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }
    }
}
