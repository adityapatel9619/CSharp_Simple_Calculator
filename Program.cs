using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint opn;

            Repat:
            Console.WriteLine("*****Simple Calculator*****");
            Console.WriteLine("1.Addition (+)");
            Console.WriteLine("2.Subtraction (-)");
            Console.WriteLine("3.Multiplication (x)");
            Console.WriteLine("4.Division (/)");
            Console.WriteLine("0.Exit");

            Console.WriteLine("\n");
            Console.WriteLine("Enter your choice:");
            opn = Convert.ToUInt32(Console.ReadLine());

            switch (opn)
            {
                case 1:         //For Addition
                    Calculation.calculate.Add();                    
                        break;
                case 2:         //For Subtraction
                    Calculation.calculate.Subtract();
                    break;
                case 3:         //For Multiplication
                    Calculation.calculate.Multiply();
                    break;
                case 4:         //For Division
                    Calculation.calculate.Divide();
                    break;
                case 0:         //For More Options
                    System.Environment.Exit(0);
                    break;
                default:        //Default
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Do you want to repeat (y/n):");
            string op = Console.ReadLine();
            if (op=="y"||op=="Y")
            {
                goto Repat;
            }
            else
            {
                Console.WriteLine("Thanks....");
                
            }
        }
    }
}
