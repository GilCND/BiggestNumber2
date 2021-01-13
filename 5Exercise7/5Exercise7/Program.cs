/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 5Exercise7
Objective: 
Write a program that finds the greatest of given 5 numbers (nested if's)
 */

using System;

namespace _5Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, number5;
            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please inform the 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inform the 2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inform the 3rd number: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inform the 4th number: ");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inform the 5th number: ");
            number5 = Convert.ToInt32(Console.ReadLine());

            //number 1 check
            if (number1 >= number2)
            {
                if (number1 >= number3)
                {
                    if (number1 >= number4)
                    {
                        if (number1 >= number5)
                        {
                            Console.WriteLine("The biggest number is the number 1: {0} ", number1);
                        }
                    }
                }
            }

            //number 2 check
            if (number2 >= number1)
            {
                if (number2 >= number3)
                {
                    if (number2 >= number4)
                    {
                        if (number2 >= number5)
                        {
                            Console.WriteLine("The biggest number is the number 2: {0} ", number2);
                        }
                    }
                }
            }

            //number 3 check
            if (number3 >= number1)
            {
                if (number3 >= number2)
                {
                    if (number3 >= number4)
                    {
                        if (number3 >= number5)
                        {
                            Console.WriteLine("The biggest number is the number 3: {0} ", number3);
                        }
                    }
                }
            }


            //number 4 check
            if (number4 >= number1)
            {
                if (number4 >= number2)
                {
                    if (number4 >= number3)
                    {
                        if (number4 >= number5)
                        {
                            Console.WriteLine("The biggest number is the number 4: {0} ", number4);
                        }
                    }
                }
            }

            //number 5 check
            if (number5 >= number1)
            {
                if (number5 >= number2)
                {
                    if (number5 >= number3)
                    {
                        if (number5 >= number4)
                        {
                            Console.WriteLine("The biggest number is the number 5: {0} ", number5);
                        }
                    }
                }
            }

        }
    }
}
