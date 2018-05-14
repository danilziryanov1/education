using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 2 числа: ");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b) Console.WriteLine((a + b).ToString());
                else Console.WriteLine((a * b).ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
