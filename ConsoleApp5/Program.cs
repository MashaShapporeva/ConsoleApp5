using System;

namespace ConsoleApp5
{
    internal class Program
    {

        private static int[] populateArray(int length)
        {

            int[] array = new int[length];
            for (int counter = 0; counter < length; counter++)
            {
                Random rnd = new Random();
                array[counter] = rnd.Next(10, 51);
            }

            return array;
        }

        private static int sumArray(int[] array)
        {
            int sum = 0;
            for (int counter = 0; counter < array.Length; counter++)
                sum = sum + array[counter];
            return sum;
        }

        static void Main(string[] args)
        {
            int numberTo = 0;
            while (numberTo < 5 || numberTo > 15)
            {
                try
                {
                    Console.WriteLine("Enter a number from 5 to 15: ");
                    numberTo = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("The input was incorrect.");
                }
            }

            int[] array = populateArray(numberTo);
            for (int counter = 0; counter < array.Length; counter++)
                Console.WriteLine(array[counter]);
            Console.WriteLine("Sum is " + sumArray(array));
        }

    }
}