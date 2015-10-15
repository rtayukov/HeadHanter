using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Count
    {
        static int a = 111;
        static int b = 129;

        
        short[] values1 = new short[a*b];

        public bool Coinc(short pow, int count)
        {
            for (int i = count; i > 0; i--){
               // Console.WriteLine(pow + "|" + values1[i]);
                if (pow == values1[i])
                    return true;
            }
            return false;
        }
        
        public void toCount(){ 
            int count = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        values1[count] = (short)Math.Pow(i + 3, j + 3);
                        count++;
                    }
                    else
                    {
                        if (!Coinc((short)Math.Pow(i + 3, j + 3), count - 1))
                        {
                            values1[count] = (short)Math.Pow(i + 3, j + 3);
                            count++;
                        }
                    }

                }
                //Console.WriteLine("-------------------------------");
            }
            Console.WriteLine(count);
        }
   
    }
}
