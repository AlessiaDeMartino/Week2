using System;
using System.Collections.Generic;

namespace Libreria
{
    class Program
    {
        static void Main(string[] args)
        {

            Menù.Start();
            /*
              Scrivere un programma che gestisca una libreria.
              Un libro è un'entità che ha:
              Codice
              Titolo
              Autore
              Genere
              Prezzo
              DataPubblicazione 
              Per il genere usare un enum
              Sarà possibile inserire un nuovo libro, eliminare un libro, modificare un libro o cercare i libri per genere
              */
            //Console.WriteLine("Hello World!");
            
            //Libro libro1 = new Libro(); //costruiscimi una cassetta, una variabile che si chiama libro che può
            //                           //contenere un libro con tutte quelle proprietà
            //                           // assegnare il codice del libro
            //libro1.Codice = "Cod001";
            //libro1.Autore = "Manzoni";
            //libro1.Titolo = "I Promessi Sposi";
            //libro1.Prezzo = 12;
            //libro1.DataPubblicazione = new DateTime(2020, 10, 12);
            //Console.WriteLine($"{libro1.Autore}");

            //Libro libro2 = new Libro(); //uso il costruttore per creare un nuovo libro
            //libro2.Codice = "Cod002";
            //libro2.Titolo = "La Divina Commedia";
            //libro2.Autore = "Dante";

            //List<Libro> libri = new List<Libro>(); //sto creando una lista che può contenere libri
            //                                       //posso aggiungere o togliere elementi
            //libri.Add(libro1);
            //Console.WriteLine($"La mia lista contiene {libri.Count}");
            //libri.Add(libro2);
            //Console.WriteLine($"La mia lista contiene {libri.Count}");
            //libri.Remove(libro1);
            //Console.WriteLine($"La mia lista contiene {libri.Count}");
        }
    }
}
