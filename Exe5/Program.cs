using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exe5
{
    class Program
    {
        static BigInteger Factorial(int numb)
        {
            if (numb == 0)
                return 1;

            BigInteger answer = 1;
            for (int i = 2; i < numb+1; i++)
            {
                answer *= i;  
            }

            return answer;
        } 

        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i < 160; i++)
            {   
                for (int j = 1; j < i; j++)
                {
                    //if ((Factorial(i) / (Factorial(j) * Factorial(i - j))) > 1000000)
                        count++;
                    //Console.WriteLine((Factorial(i) + "/" + (Factorial(j) + "*" + Factorial(i - j))) + " = " + (Factorial(i) / (Factorial(j) * Factorial(i - j))));
                    //Console.ReadKey();
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
