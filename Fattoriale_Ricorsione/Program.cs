using System;

namespace Fattoriale_Ricorsione
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int fatt=1;
            for (int i=2; i<=n; i++)
            {
                fatt = fatt * i;
            }

            Console.WriteLine($"{fatt}");

            //RICORSIONE
            int num = 6;
            int nRic = Fattoriale_Ricorsione(num);
            Console.WriteLine($"Il fattoriale ricorsivo vale {nRic}");
        }
        

        private static int Fattoriale_Ricorsione(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                return Fattoriale_Ricorsione(n-1) * n;
            }
        }
    }
}
