using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var arr = new double[15];
                var count = 0;
                var random = new Random();

                arr[0] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);
                Console.Write(arr[0] + " ");

                for (int i = 1; i < arr.Length; i++)

                {
                    arr[i] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);
                    if (arr[i] > arr[0])

                    {
                        count++;
                    }

                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine(count);
                Console.ReadKey();
            }
        }
    }
}
