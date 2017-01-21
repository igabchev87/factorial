using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // :)
            int num = 0, factorial = 0, counter = 0;
            Console.Write("n= ");
            num = Convert.ToInt32(Console.ReadLine());

            factorial = num;
            counter = num - 1;
            while (counter > 0)
            {
                factorial *= counter;
                counter--;

            }
            Console.WriteLine("{0}!={1}",num,factorial);
        }
    }
}