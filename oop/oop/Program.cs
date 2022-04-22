using System;

namespace oop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int x = 9;
            int y = 9;
            int sum = 0;
            int sub = 0;
            int mul = 0;
            float div = 0;
            float a = 6, b = 9;


            sum = calc.Add(x, y);
            sub = calc.Subtract(x, y);
            mul = calc.Multiply(x, y);
            div = calc.Divide(a, b);




            Console.WriteLine("Sum of {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("Sum of {0} + {1} = {2}", x, y, sub);
            Console.WriteLine("Sum of {0} + {1} = {2}", x, y, mul);
            Console.WriteLine("Sum of {0} + {1} = {2}", x, y, div);
            Console.ReadLine();


        }
    }
}
