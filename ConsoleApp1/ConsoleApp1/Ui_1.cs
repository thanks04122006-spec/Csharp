using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Ui_1
    {
        static void Main(string[] args)
        {
            //char a = 'a';
            //char b = 'b';

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //Console.Write("입력:");
            //string Num2 = Console.ReadLine();
            //Console.Write("입력2:");
            //string Num1 = Console.ReadLine();
            ////Console.WriteLine(">>" + inout);

            //Console.WriteLine(int.Parse(Num2) + int.Parse(Num1));

            //double number = 52.273103;
            //Console.WriteLine(number.ToString("0.0"));
            //Console.WriteLine(number.ToString("0.00"));
            //Console.WriteLine(number.ToString("0.000"));
            //Console.WriteLine(number.ToString("0.0000"));

            Console.Write("입력:");
            string Num2 = Console.ReadLine();
            Console.Write("입력2:");
            string Num1 = Console.ReadLine();

            Console.WriteLine(Num2 + "+" + Num1 + "=" + (int.Parse(Num2) + int.Parse(Num1)));
            Console.WriteLine(Num2 + "-" + Num1 + "=" + (int.Parse(Num2) - int.Parse(Num1)));
            Console.WriteLine(Num2 + "x" + Num1 + "=" + (int.Parse(Num2) * int.Parse(Num1)));
            Console.WriteLine(Num2 + "÷" + Num1 + "=" + (int.Parse(Num2) / int.Parse(Num1)));

        }
    }
}
