using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int count = array.Count(e => e % 2 == 0 && e >= 0);
            int sum = array.Where(e => e % 2 == 0 && e >= 0).Sum();
        }
    }
}
