using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] box = { 35, 44, 65, 87, 21, 19, 98, 34, 45, 31 };
            Show(box);
            Swap(ref box[0], ref box[Array.IndexOf(box, box.Max())]);
            Show(box);
            Console.ReadKey();
        }
        public static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
        }
        public static void Show(int[] box)
        {
            foreach (var x in box) Console.Write($"{x,3}");
            Console.WriteLine();
        }
    }
}
        
   
