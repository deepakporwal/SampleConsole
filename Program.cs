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

            clsStudent obj = new clsStudent();
            obj.StudentID = 100;
            obj.StudentName = "deepak";
            obj.Age = 33; 
        
        }

        static int Sum(int x,int y)
            {
                return x+ y;
            }
        static int Substract(int x, int y)
        {
            return x-y;
        }
    }
}
