using System;

namespace Functions
{
    class MainClass
    {
         public static void Main(string[] args)
        {
            /*
            String a;
            String b;
            int sum = 0;

            Console.WriteLine("Enter the first number");
            a = Console.ReadLine();

            int x = int.Parse(a);


            Console.WriteLine("Enter the first number");
            b = Console.ReadLine();

            int y = int.Parse(b);


            sum = Add(x, y);
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();
            */

            Console.WriteLine("Please enter a number ");
            String x1 = Console.ReadLine();

            double x2 = double.Parse(x1);

            double sqt = sqreroot(x2);

            Console.WriteLine("sqrt = {0}", sqt);
            Console.ReadLine();

        }

        public static double sqreroot(double a)
        {
            return Math.Sqrt(a);

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
