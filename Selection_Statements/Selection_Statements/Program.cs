﻿using System;

namespace Selection_Statements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int firstNumber = 0;
            int secondNumber = 0;
            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number is larger than second number");
                
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("first number equals second number");
            }
            else
            {
                Console.WriteLine("Second number is greater than first number");
            }
            Console.ReadLine();
        }
    }
    
}
