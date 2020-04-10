using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Calculator.Calculation
{
   public static class calculate
    {
       
        public static void Add()
        {
            double a, b, c;
            Console.WriteLine("Enter Number 1:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            b = Convert.ToDouble(Console.ReadLine());

            c = a + b;
            Console.WriteLine("******************");
            Console.WriteLine($"{a} + {b} = {c}");    
        }

        public static void Subtract()
        {
            double a, b, c;
            Console.WriteLine("Enter Number 1:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            b = Convert.ToDouble(Console.ReadLine());

            c = a - b;
            Console.WriteLine("******************");
            Console.WriteLine($"{a} - {b} = {c}");
        }

        public static void Multiply()
        {
            double a, b, c;
            Console.WriteLine("Enter Number 1:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            b = Convert.ToDouble(Console.ReadLine());

            c = a * b;
            Console.WriteLine("******************");
            Console.WriteLine($"{a} * {b} = {c}");
        }

        public static void Divide()
        {
            double a, b, c;
            Console.WriteLine("Enter Number To be divided:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number:");
            b = Convert.ToDouble(Console.ReadLine());

            c = a / b;
            Console.WriteLine("******************");
            Console.WriteLine($"{a} + {b} = {c}");
        }



    }
}
