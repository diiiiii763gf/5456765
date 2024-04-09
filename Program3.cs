using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random rand = new Random();

                int[] arr = new int[20];
                int countEven = 0;
                int countOdd = 0;

                for (int i = 0; i < 20; i++)

                {
                    arr[i] = rand.Next(1, 20);
                    if (arr[i] % 2 == 0) countEven++;
                    else countOdd++;
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();

                if (countEven > countOdd) Console.WriteLine("Четных элементов больше");
                else
                if (countEven < countOdd) Console.WriteLine("Нечетных элементов больше");
                else Console.WriteLine("Равное количество элементов");
                Console.ReadLine();
            }
        }
    }
}
