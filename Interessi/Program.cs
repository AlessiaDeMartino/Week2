using System;

namespace Interessi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrivere una funzione che dato un importo di denaro iniziale,
            // un interesse annuo e un numero di anni permette di calcolare
            // l’importo di denaro accresciuto degli interessi dopo il numero di anni passati

            // Esempio
            // Voglio vincolare 10000 euro per 3 anni con un interesse del 3%

            // Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
            // Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
            // Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10927,27

            //double import = 10000;
            //double interesse = 0.03;
            //int anni = 3;


            Console.WriteLine("Inserire importo denaro iniziale");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire interesse annuo");
            double interess = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire numero di anni");
            int years = Convert.ToInt32(Console.ReadLine());


            //double moneyMaturati = CalcoloAnnuo(money, interess, years);
            double moneyMaturati = CalcoloAnnuoRicorsione(years, money,interess);
            Console.WriteLine($"Dopo {years} anni, riesci a maturare {moneyMaturati} euro ");


        }

        //private static double CalcoloAnnuo(double money, double interess, int years)
        //{
        //    double count = money;
        //    for (int i = 1; i <= years; i++)
        //    {

        //        count = count + (count * interess);

        //    }
        //    return count;
        //}

        private static double CalcoloAnnuoRicorsione (int anni, double money, double interess)
        {
            if (anni==1)
            {
                return (money+(money*interess));
             }
         else
            {
                return CalcoloAnnuoRicorsione((anni-1),money,interess)+(money*interess);
            }

        }
    }
    }

