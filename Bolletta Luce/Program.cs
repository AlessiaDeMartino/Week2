using System;

namespace Bolletta_Luce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bolletta Luce!");
            //Console.WriteLine("****Menù****");
            //Console.WriteLine("\nInserire nome: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("\nInserire cognome: ");
            //string surname = Console.ReadLine();
            string nome_cognome = InserireDati(out int kwH);
            //Console.WriteLine("\nInserire kwH consumati: ");
            //OPPURE:
            //int kwH = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out kwH);
            int price = calcolaPrezzo(kwH);
            //Console.WriteLine($"Ciao {nome_cognome}, il calcolo del costo della tua bolletta risulta: {price}");
            Stampa(nome_cognome, price);
        }
        private static int calcolaPrezzo(int kw) //con int non ci sono problemi
        {
            int price = 40+ kw*10;
            return price;
        }
        private static string InserireDati(out int kwh)
        {
            Console.WriteLine("Bolletta Luce!");
            Console.WriteLine("****Menù****");
            Console.WriteLine("\nInserire nome e cognome: ");
            string name_surname = Console.ReadLine();
            Console.WriteLine("\nInserire kwH consumati: ");
            int.TryParse(Console.ReadLine(), out kwh);
            return name_surname;
        }
        private static void Stampa(string nome_cognome, double kilowatt)
        {
            Console.WriteLine($"Ciao {nome_cognome}, il calcolo del costo della tua bolletta risulta: {kilowatt}");
        }
    }
    }

