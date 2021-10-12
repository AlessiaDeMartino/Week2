using System;

namespace Bolletta_Luce_versione_Menù
{
    class Program
    {
        /*Realizzare un’applicazione console che consenta di eseguire il calcolo della bolletta della luce.
    Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
    inserire i propri dati (nome, cognome e kwH consumati);
    richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
    stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
    Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.
    */
        static void Main(string[] args)
        {
            //Console.WriteLine("Bolletta Luce!");
            //Console.WriteLine("****Menù****");
            //Console.WriteLine("Premere [1] per inserire nome e cognome ");
            //Console.WriteLine("Premere [2] per calcolo costo bolletta:");
            //Console.WriteLine("Premere [3] per stampare");
            //int scelta;
            //do
            //{
            //    Console.WriteLine("Scegli un'opzione tra quelle del Menù: ");
            //} while(!(int.TryParse(Console.ReadLine(), out scelta) && scelta>0 && scelta <=3));
            ////int choice = Convert.ToInt32(Console.ReadLine());
            string nome = null; ;
            string cognome = null ;
            double kwh = 0;
            double costoBolletta = 0;
            bool choice = true;
            while (choice)
            {
                int scelta = Menu();
                switch (scelta)
                {
                    case 1:

                        InserireDati(ref nome, ref cognome, ref kwh);
                        Console.WriteLine($"Ciao {nome}  {cognome}, i kwh consumati sono: {kwh}");

                        break;

                    case 2:

                        costoBolletta = calcolaPrezzo(kwh);
                        Console.WriteLine($"Ciao {nome}  {cognome}, il prezzo della bolletta è: {costoBolletta} €");
                        break;

                    case 3:

                        Stampa(nome, cognome, costoBolletta);
                        break;
                    case 0:
                        choice = false;
                        Console.WriteLine("Esci dal programma");
                        return;
                }
            }
        }

        private static int Menu()
        {
            Console.WriteLine("Bolletta Luce!");
            Console.WriteLine("****Menù****");
            Console.WriteLine("Premere [1] per inserire nome e cognome ");
            Console.WriteLine("Premere [2] per calcolo costo bolletta:");
            Console.WriteLine("Premere [3] per stampare");
            Console.WriteLine("Premere [0] per uscire");
            int scelta;
            do
            {
                Console.WriteLine("Scegli un'opzione tra quelle del Menù: ");
            } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 3));
            return scelta;
        }
        private static void InserireDati(ref string name, ref string surname, ref double kwh)
        {
            Console.WriteLine("\nInserire nome: ");
            name = Console.ReadLine();
            Console.WriteLine("\nInserire cognome: ");
            surname = Console.ReadLine();
            Console.WriteLine("\nInserire kwH consumati: ");
            double.TryParse(Console.ReadLine(), out kwh);
            
        }
        private static double calcolaPrezzo(double kw) //con int non ci sono problemi
        {
            double price = 40 + kw * 10;
            return price;
        }
        private static void Stampa(string name, string surname, double price)
        {
            Console.WriteLine($"Ciao {name}  {surname}, il calcolo del costo della tua bolletta risulta: {price}");
        }
    }
}
