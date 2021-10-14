using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public static class LibreriaManager
    {

        public static List<Libro> libri = new List<Libro>();

        public static void AggiungiDatiProva()
        {
            Libro libro1 = new Libro()
            {
                Codice = "L001",
                Titolo = "I promessi sposi",
                Autore = "Manzoni",
                Prezzo = 10,
                Genere = (Genere)1,    //mi rende il nome del genere che vale 1=Narrativo
                DataPubblicazione = new DateTime(2010, 10, 12)
            };

            libri.Add(libro1);        
    }
        
        public static void AggiungiLibro()
        {   //Chiedo all'utente i dati necessari per poter creare un libro;


            Libro libro = new Libro(); //Un libro ''vuoto''

            Console.WriteLine("Inserisci Codice del libro");
            libro.Codice=Console.ReadLine();
            Console.WriteLine("Inserisci Titolo del libro");
            libro.Titolo = Console.ReadLine();
            Console.WriteLine("Inserisci Autore del libro");
            libro.Autore = Console.ReadLine();
            
            libro.Prezzo = InserisciPrezzo();
            libro.DataPubblicazione = InserisciDataPubblicazione();
            libro.Genere = InserisciGenere();
            libri.Add(libro);

            Console.WriteLine("Libro aggiunto correttamente");
        }

        private static Genere InserisciGenere()
        {
            Console.WriteLine("Inserisci Genere del libro");
            Console.WriteLine($"Premi {(int)Genere.Narrativa} per il genere {Genere.Narrativa}");
            Console.WriteLine($"Premi {(int)Genere.Storico} per il genere {Genere.Storico}");
            Console.WriteLine($"Premi {(int)Genere.Fantasy} per il genere {Genere.Fantasy}");
            int genere;
            do
            {
                Console.WriteLine("Fai la tua scelta: ");
            } while (!(int.TryParse(Console.ReadLine(), out genere) && genere >= 1 && genere <= 3));

            return (Genere)genere;  //se ho scelto 1 mi rende narrativa che è associato all'1.
        }

        private static DateTime InserisciDataPubblicazione()
        {
            DateTime data;
            do
            {
                Console.WriteLine("Inserisci Data del libro");
            } while (!(DateTime.TryParse(Console.ReadLine(), out data) && data<= DateTime.Today));
            return data;

        }

        private static double InserisciPrezzo() //mi serve solo in questo file, quindi può rimanere private
        {
            double prezzo;
            do
            {
                Console.WriteLine("Inserisci Prezzo del libro");
            } while (!(double.TryParse(Console.ReadLine(), out prezzo) && prezzo > 0));
            return prezzo;
        }
        public static Libro CercaLibro(string codice)
        {
            foreach (var item in libri)
            {
                if (codice == item.Codice)
                {
                    return item;
                }                
            }
            return null;

        }
        public static void EliminaLibro()
        {
            Console.WriteLine("I libri presenti nella libreria sono: ");
            StampaLibro();
            Console.WriteLine("Scrivi il codice del libro che vuoi eliminare: ");
            string codiceDaRicercare = Console.ReadLine();
            Libro librotrovato= CercaLibro(codiceDaRicercare);
            if (librotrovato == null)
            {
                Console.WriteLine("Codice non trovato");
            }
            else
            {
                libri.Remove(librotrovato);
                Console.WriteLine("Libro eliminato");
            }
        }
        public static void ModificaLibro()
        {
            //stampo i libri
            Console.WriteLine("I libri presenti nella libreria sono: ");
            StampaLibro();
            //scegli il libro che vuoi modificare per codice
            Console.WriteLine("Inserisci il codice del libro che vuoi  modificare: ");
            string codice = Console.ReadLine();
            
            //menù con possibili opzioni (es.1 per modifica titolo, es 2. per modifica autore);
            Libro libroDaModificare=CercaLibro(codice);
            if (libroDaModificare == null)
            {
                Console.WriteLine("Nessun libro corrispondente al codice inserito");
            } else
            {        bool continua = true;
                do {
                    Console.WriteLine("Premi 1 per modificare il Titolo");
                    Console.WriteLine("Premi 2 per modificare l'Autore");
                    Console.WriteLine("Premi 3 per modificare il Genere");
                    Console.WriteLine("Premi 4 per modificare il Prezzo");
                    Console.WriteLine("Premi 5 per modificare la Data di Pubblicazione");
                    Console.WriteLine("Premi 0 per concludere la modifica");
                    int choice;
                   
                    do
                    {
                        Console.WriteLine("Fai la tua scelta: ");
                    } while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 5));
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Inserire il nuovo titolo");
                            string newTitle = Console.ReadLine();
                            libroDaModificare.Titolo = newTitle;
                            break;

                        case 2:
                            Console.WriteLine("Inserire il nuovo Autore");
                            string newAuthor = Console.ReadLine();
                            libroDaModificare.Autore = newAuthor;
                            break;

                        case 3:
                            Genere genNew = InserisciGenere();
                            libroDaModificare.Genere = genNew;
                            break;
                        case 4:
                            double Price = InserisciPrezzo();
                            libroDaModificare.Prezzo = Price;
                            break;

                        case 5:
                            DateTime newData = InserisciDataPubblicazione();
                            libroDaModificare.DataPubblicazione = newData;
                            break;
                        case 0:
                            continua = false;
                            break;
                    }
                } while (continua);
             }
            
            

        }
        public static void StampaLibro()
        {
            StampaLibriDiUnaLista(libri);
        }
        public static void StampaLibriDiUnaLista(List<Libro> listaLibri)
        {
            //controllo se la lista generica è piena
            if (listaLibri.Count ==0)
            {
                Console.WriteLine("Lista Vuota");
            }
            {
                Console.WriteLine("Codice\t\tTitolo\t\tAutore\t\tGenere\t\tPrezzo\t\tDataPubblicazione");
                foreach (var item in listaLibri) //(Libro libro in listaLibri)
                {
                    Console.WriteLine($"{item.Codice}\t\t{item.Titolo}\t\t{item.Autore}\t\t{item.Genere}\t\t{item.Prezzo}\t\t{item.DataPubblicazione}");
                }
            }
        }                
        public static void FiltraLibriPerGenere()
        {
            Genere g=InserisciGenere();
            List<Libro> libriFiltrati = new List<Libro>();
            foreach(var item in libri)
            {
                if(item.Genere==g)
                {
                    libriFiltrati.Add(item);
                }

            }
            StampaLibriDiUnaLista(libriFiltrati);
        }
    }
}
