﻿using System;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // demonstrate for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("New comment added by deepak");
        
        }

        static int Sum(int x,int y)
            {
                return x+ y;
            }
        static int Substract(int x, int y)
        {
            return x-y;
        }


        static int Mul(int a,int b)
        {
            return a*b;
        }
    }
}
