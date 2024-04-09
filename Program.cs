using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[12];
            int imax = 0, max = 0, i = 0;
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(" Введите {0}-й элемент массива", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" Исходный массив:");
            for (i = 0; i < a.GetLength(0); i++)
            {
                if (a[i] >= max)
                {
                    max = a[i];
                    imax = i;
                }
                Console.Write(a[i] + " ");
            }
            int temp = a[4];
            a[4] = a[imax];
            a[imax] = temp;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Массив после замены первого и максимального элемента:");
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
