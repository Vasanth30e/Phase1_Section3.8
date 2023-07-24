using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        public static void doApp()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + dt.ToString());
            Console.WriteLine("Formatted short date: " + dt.ToShortDateString());
            Console.WriteLine("Formatted long date: " + dt.ToLongDateString());
            Console.WriteLine("Formatted custom date strings: ");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("y"));

            Console.WriteLine("Adding 5 days to today: " + dt.AddDays(5).ToShortDateString());

            DateTime date1 = new DateTime(2019, 1, 2, 4, 0,15);
            DateTime date2 = new DateTime(2019, 1, 2, 14, 0, 15);

            TimeSpan value = date1.Subtract(date2);

            Console.WriteLine("TimeSpan between two dates is {0} hours",value);

        }
    }
}
