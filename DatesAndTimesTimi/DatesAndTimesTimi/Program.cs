// DatesAndTimesTimi
// Name: Timi Owoturo
// Teachers Name: Miss Lischynski
// Date: 13/04/2016
// Description: Learning to use the date and time methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimesTimi
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //onsole.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());

            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthDate = new DateTime(1997, 07, 11);
            DateTime myBirthdate = DateTime.Parse("1997, 07, 11");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);

            Console.WriteLine(myAge.TotalDays.ToString());

            Console.ReadLine();
        }
    }
}
