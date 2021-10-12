using System;

namespace Bolletta_Luce
{  /*Realizzare un’applicazione console che consenta di eseguire il calcolo della bolletta della luce.
    Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
    inserire i propri dati (nome, cognome e kwH consumati);
    richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
    stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
    Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.
    */
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
            string nome_cognome = InserireDati(out double kwH);
            //Console.WriteLine("\nInserire kwH consumati: ");
            //OPPURE:
            //int kwH = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out kwH);
            double price = calcolaPrezzo(kwH);
            //Console.WriteLine($"Ciao {nome_cognome}, il calcolo del costo della tua bolletta risulta: {price}");
            Stampa(nome_cognome, price);
        }
        private static double calcolaPrezzo(double kw) //con int non ci sono problemi
        {
            double price = 40+ kw*10;
            return price;
        }
        private static string InserireDati(out double kwh)
        {
            Console.WriteLine("Bolletta Luce!");
            Console.WriteLine("****Menù****");
            Console.WriteLine("\nInserire nome e cognome: ");
            string name_surname = Console.ReadLine();
            Console.WriteLine("\nInserire kwH consumati: ");
            double.TryParse(Console.ReadLine(), out kwh);
            return name_surname;
        }
        private static void Stampa(string nome_cognome, double kilowatt)
        {
            Console.WriteLine($"Ciao {nome_cognome}, il calcolo del costo della tua bolletta risulta: {kilowatt}");
        }
    }
    }

