using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Decimal n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            Decimal n2 = Convert.ToDecimal(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(Sum(n1, n2));
                Console.ReadLine();
            }

            else if (op == "-")
            {
                Console.WriteLine(Dif(n1, n2));
                Console.ReadLine();
            }

            else if (op == "*")
            {
                Console.WriteLine(Prod(n1, n2));
                Console.ReadLine();
            }

            else if (op == "/")
            {
                Console.WriteLine(Div(n1, n2));
                Console.ReadLine();
            }

            else if (op == "^")
            {
                Console.WriteLine(Pow(n1, n2));
                Console.ReadLine();
            }

            //else
            {
                Console.WriteLine("Invalid Operator! Only '+', '-', '*', '/', or '^' allowed.");
                Console.ReadLine();
            }
        }

        static Decimal Sum(Decimal n1, Decimal n2)
        {
            Decimal sum;
            sum = n1 + n2;
            return sum;
        }

        static Decimal Dif(Decimal n1, Decimal n2)
        {
            Decimal dif;
            dif = n1 - n2;
            return dif;
        }

        static Decimal Prod(Decimal n1, Decimal n2)
        {
            Decimal prod;
            prod = n1 * n2;
            return prod;
        }

        static Decimal Div(Decimal n1, Decimal n2)
        {
            Decimal div;
            div = n1 / n2;
            return div;
        }

        static Decimal Pow(Decimal n1, Decimal n2)
        {
            Decimal pow;
            pow = (decimal)Math.Pow((double)n1, (double)n2);
            return pow;
        }
    }
}