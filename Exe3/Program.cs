using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    class Program
    {

        static bool Equal2(long a, long b)
        {
            var arrayA = a.ToString().ToCharArray();
            var arrayB = b.ToString().ToCharArray();

            Array.Sort(arrayA);
            Array.Sort(arrayB);

            for (int i = 0; i < arrayA.Length; i++)
                if (arrayA[i]!=arrayB[i])
                    return false;
            return true;
        }


        static void Main(string[] args)
        {
            long a=0;
            long b=0;
            long x = 5435;
            bool check=false;

            while (check != true)
            {
                a = x * 2 ;
                b = x * 5; 
                
                if ((int)Math.Log10(a) + 1 == (int)Math.Log10(b) + 1)
                {

                    if (Equal2(a, b)) check = true;
                    
                }
                x++;
            }
            Console.WriteLine("x = "+x+" | "+"a = "+a+" | "+"b = "+b);
            Console.ReadKey();
        }
    }
}
