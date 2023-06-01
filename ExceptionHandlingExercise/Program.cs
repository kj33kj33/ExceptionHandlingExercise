using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            var str = String.Empty; 

            foreach(char character in arr)
            {
                try
                {
                    str = character.ToString();
                    var integer = int.Parse(str);
                    numbers.Add(integer);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
