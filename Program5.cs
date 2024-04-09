using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] num = new double[16];
            
            int indexMax = Array.IndexOf(num, num.Max()); 
                                                          
            int indexMin = Array.IndexOf(num, num.Min()); 

            Console.WriteLine($"Max = {indexMax} Min = {indexMin}");
            Console.ReadLine();
        }
    }
}
