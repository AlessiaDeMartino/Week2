using System;
using System.IO;

namespace ScritturaELettura_dei_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Alessia\Desktop\Week2\calcolatrice_week2\ScritturaELettura dei File\fileprova.txt";
            //aggiungo \fileprova.txt il nome del file che voglio creare.
           /* StreamWriter sw = new StreamWriter(@"fileprova.txt")*/; //finisce in bin di default, senza string path=...
            //con string path, vedo il file nella cartella che gli dico io .

            /// Scrittura su file con chiusura manuale
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Ciao a tutte!");
            sw.Close();

            // Scrittura file con chiusura automatica-> using

            // Sovrascrivere su file sovrascrivendo il contenuto precedente
            using (StreamWriter sw1 = new StreamWriter(path)) 
            {
                sw1.WriteLine("Buongiorno!");
            }

            // Scrittura su file mantenendo la scrittura precedente
            using (StreamWriter sw1 = new StreamWriter(path, true))
            {
                sw1.WriteLine("Come state?");
            }

            // Lettura di tutto il file 
            using (StreamReader sr1 = new StreamReader(path))
            {
                string contenutoFile= sr1.ReadToEnd();    //rende tutti i caratteri che legge in una stringa 
            }

            // Lettura di una riga dal file 
            using (StreamReader sr1=new StreamReader(path))
            {
                string contenutoRiga = sr1.ReadLine(); //Legge la prima riga di default
            }

            //Lettura di tutto il file e divisione del file in righe
            using (StreamReader sr1 = new StreamReader(path))
            {
                string contenutoFile = sr1.ReadToEnd();
                var arrayDiRighe = contenutoFile.Split("\r\n"); //rende una stringa
            }
        }
    }
}
