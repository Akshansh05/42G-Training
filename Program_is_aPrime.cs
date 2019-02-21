using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = { "13", "17", "22", "3467", null, "notNumber", "55" };
            int a;
            for( int i = 0; i < testArray.Length; i++)
            {
                bool res = Int32.TryParse(testArray[i],out a);
                int k;
                if (res==true)
                {
                    k = a;
                    int flag = 0;
                    for(int r = 2; r <= k / 2; r++)
                    {
                        if (k % r == 0)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(k);
                }
            }
            Console.ReadKey();

        }
    }
}
