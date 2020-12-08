using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string filename = @"C:\Users\Aris\source\repos\Advent of code\Advent of code\bin\Debug\netcoreapp3.1\numbers.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            List<int> numbers = new List<int>();
            while ((line = file.ReadLine()) != null)
            {
                int number = Convert.ToInt32(line);
                numbers.Add(number);
            }
            //Part 1 of Day 1 code
            int len = numbers.Count;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {

                    if(numbers[i] + numbers[j] == 2020)
                    {
                        Console.WriteLine("First number is {0}, second number is {1}", numbers[i],numbers[j]);
                        Console.WriteLine("The final answer is {0}", numbers[i]* numbers[j]);
                    }
                }
            }
            //Part 2 of Day 1 code
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 2020)
                        {
                            Console.WriteLine("First number is {0}, second number is {1}, third number is {2}", numbers[i], numbers[j], numbers[k]);
                            Console.WriteLine("The final answer is {0}", numbers[i]* numbers[j]* numbers[k]);
                        }
                    }
                    
                }
            }
        }
    }
}
