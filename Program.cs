//Beni Yaratan Elbet Yolumu Gösterir .Şuara 78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            int sub;
            int mult;
            int division;

            Console.WriteLine("Please Enter First Number:");
            number1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number:");
            number2 = Convert.ToInt16(Console.ReadLine());

            sum = number1 + number2;
            sub = number1 - number2;
            mult = number1 * number2;
            division = number1 / number2;

            Console.WriteLine("Sum of two numbers: "+" "+ sum);

            Console.WriteLine("Substraction of two numbers: " + " " + sub);

            Console.WriteLine("Multipication of two numbers: " + " " + mult);

            Console.WriteLine("Division of two numbers: " + " " + division);

            Console.Read();


        }
    }
}
