using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = new int[a1.Length];
            int[] a3 = new int[a1.Length];
            Console.WriteLine("Using Copy Function");
            a1.CopyTo(a2, 0);
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine(a2[i]);
            }
            Console.WriteLine("Without Using Copy Function");
            for (int i = 0; i < a1.Length; i++)
            {
                a3[i] = a1[i];
            }
            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine(a3[i]);
            }

            add(5, 15, out int z);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The value After Sum Using Out");
            Console.WriteLine("{0}", z);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usage of ref for swap");
            int q = 5;
            int r = 8;
            Console.WriteLine();
            Console.WriteLine("Before swap val1 {0} and val2 {1} ", q, r);
            Method(ref q, ref r);
            Console.WriteLine("After swap val1 {0} and val2 {1} ", q, r);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Matrix");
            int[,] Matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", Matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static int add(int a, int b, out int w)
        {
            int c = a + b;
            w = c;
            return c;
        }
        static void Method(ref int val1, ref int val2)
        {
            int z = val1;
            val1 = val2;
            val2 = z;
        }

    }

}
