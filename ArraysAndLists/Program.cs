using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNum = new List<int>();
            var oddNum = new List<int>();
            foreach (var value in numbers)
            {
                if (value % 2 == 1) 
                { 
                    oddNum.Add(value);
                }
                else
                {
                    evenNum.Add(value);
                }
            }
            Console.WriteLine("Odd Numbers:");
            for (var i = 0; i < oddNum.Count; i++)
            {
                Console.Write($"{oddNum[i]}, ");
            }
            Console.WriteLine("\n\nEven Numbers:");
            for (var i = 0;i < evenNum.Count; i++)
            {
                Console.Write($"{evenNum[i]}, ");
            }
        }
    }
}
