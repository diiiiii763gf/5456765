using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[15];
                int[] arr_result = new int[arr.Length];
                arr.CopyTo(arr_result, 0);
                int average = 0;

                for (int i = 0; i < arr.Length; i++)
                {

                    average += arr[i];

                }
                average /= arr.Length;

                for (int i = 0; i < arr.Length; i++)
                {

                    arr_result[i] = average - arr_result[i];

                }

            }

        }
    }
    
}
