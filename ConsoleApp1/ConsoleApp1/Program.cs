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
            Console.WriteLine("first digit: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("second digit: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operators: 1-'+', 2-'-', 3-'*', 4-'/', 5-'^'");
            int _operator = Convert.ToInt32(Console.ReadLine());

            if (_operator > 0 && _operator < 6)
            {
                switch (_operator)
                {
                    case 1:
                        Summ summ = new Summ();
                        summ.Result(a, b);
                        break;
                    case 2:
                        Subtraction subtraction = new Subtraction();
                        subtraction.Result(a, b);
                        break;
                    case 3:
                        Multiply multiply = new Multiply();
                        multiply.Result(a, b);
                        break;
                    case 4:
                        Dividing dividing = new Dividing();
                        dividing.Result(a, b);
                        break;
                    case 5:
                        Degree degree = new Degree();
                        degree.Result(a, b);
                        break;
                }
            }
            else Console.WriteLine("Operator not found");

            Console.ReadKey();
        }
    }
    interface ICalculate
    {
        void Result(double a, double b);
    }
    class Summ : ICalculate
    {
        public void Result(double a, double b)
        {
            Console.WriteLine("Сумма = "+(a + b).ToString());
        }
    }
    class Subtraction : ICalculate
    {
        public void Result(double a, double b)
        {
            Console.WriteLine("Разность = " + (a - b).ToString());
        }
    }
    class Multiply : ICalculate
    {
        public void Result(double a, double b)
        {
            Console.WriteLine("Умножение = " + (a * b).ToString());
        }
    }
    class  Dividing : ICalculate
    {
        public void Result(double a, double b)
        {
            Console.WriteLine("Деление = " + (a / b).ToString());
        }
    }
    class Degree : ICalculate
    {
        public void Result(double a, double b)
        {
            Console.WriteLine("Возведение в степень = " + Math.Pow(a,b).ToString());
        }
    }

}
