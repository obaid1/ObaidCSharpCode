using System;

namespace Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;

            
            do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0} sum: {1}", count, sum);
                count++;
            } while (count != 10);
            
            
            
            //while loop
            while (count!= 50)
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0} sum: {1}", count, sum);
                count++;
            }
            Console.WriteLine("End loop");

            int i; 
            for (i = 1; i<=100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of loop");


            //Display numbers in the array
            int[] arr = { 2, 4, 6, 8, 10 };

            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }













        }
    }
}
