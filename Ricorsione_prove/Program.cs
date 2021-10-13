using System;

namespace Ricorsione_prove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[] newarray = new int[n];
            newarray[0] = 1;
            newarray[1] = 1;
            for (int i = 2; i < (newarray.Length); i++)
            {
                newarray[i] = newarray[i-2] + newarray[i-1];
            }

            Console.WriteLine($"{newarray}"); 
            //FIBONACCI ricorsione
        int fibonacciRicorsione=Ricorsione_prove(n);
        }
       

        private static int Ricorsione_prove(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
            {
                return Ricorsione_prove(n - 1) + Ricorsione_prove(n - 2);
            }
        }
    }
}
