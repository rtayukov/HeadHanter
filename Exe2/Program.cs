using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exe2
{
    class Program
    {
       static void Phibonachi(long num1, long num2, ref string str){
            long currentNum = num1 + num2;
            str+="\r\n"+currentNum.ToString();
            Console.WriteLine(str);
            if (((int)Math.Log10(currentNum)+1)<11)
            {
                 Phibonachi(num2, currentNum,ref str);
            }
        }

        static void Main(string[] args)
        {

            int memOfNumb = 3;
            int amountOfFive = 2;
            int countOfNumb = 1;


            while (countOfNumb < 1368)
            {    
                memOfNumb += 4;
                countOfNumb++;

                //Console.WriteLine(memOfNumb);
                //Console.WriteLine(countOfNumb);
                //Console.WriteLine("-------------------");
                //Console.ReadKey();
                
                for (int i = 0; i < amountOfFive; i++)
                {
                    if (countOfNumb < 1368)
                    {
                        memOfNumb += 5;
                        countOfNumb++;
                    }

                    //Console.WriteLine(memOfNumb);
                    //Console.WriteLine(countOfNumb);
                    //Console.WriteLine("-------------------");
                    //Console.ReadKey();
                }
                
                amountOfFive++;
                                
            }
            Console.WriteLine(memOfNumb);
            Console.WriteLine(countOfNumb); 
            Console.ReadKey();
       
        }

    }
}
