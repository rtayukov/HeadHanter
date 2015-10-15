using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exe4
{
    class Program 
    {
        static string GetLastDigits(int n, int max)
        {
            long temp = 0;
            unchecked
            {
                for (int i = 1; i < max; i++)
                    temp += UncheckedPow(i);
            }
            String result = temp.ToString();
            return result.Length > n ? result.Substring(result.Length - n, n) : result;
        }

        static long UncheckedPow(int x)
        {
            long result = 1;
            unchecked
            {
                for (int i = 0; i < x; i++)
                { 
                    result *= x;
                }

                return (long)result;
            }
        }

        static void Main(string[] args)
        {
            //BigInteger value = 0;
            //for (int i = 1; i < 1377+1; i++)
            //{
            //    value += (BigInteger)Math.Pow(i, i);
                
            //    //Console.WriteLine("i = " + i + " Count = " + value);

            //    //Console.WriteLine("i = " + i + " " + (long)Math.Pow(i, i));
            //    //Console.ReadKey();
            //}
            //value = value % 10000000000;
            int n = 10;
            int max = 1377;
            var value = GetLastDigits(n, max);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
