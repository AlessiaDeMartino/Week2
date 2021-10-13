﻿using System;
using System.IO;

namespace Indovina_Numero_con_Metodi
{
    //Esercizio: Indovina Numero.
    //Il gioco consiste nell’indovinare un numero tra 1 e 100, generato in modo casuale.


    //L’utente accede e visualizza un messaggio di benvenuto.
    //Gli viene chiesto di inserire il suo nome, quindi, una volta inserito,
    //compare un messaggio del tipo “Ciao NOME!” ed un menu con delle scelte/opzioni.
    //In particolare potrà scegliere se iniziare a giocare una partita o uscire dal programma.


    //Se l’utente decide di uscire, verrà visualizzato un messaggio di arrivederci.


    //Se invece decide di giocare dovrà essere generato un numero casuale
    //che ovviamente NON dovrà essere mostrato a video.
    //(Opzionale: il numero può essere salvato in un file “NumeroDaIndovinare.txt”).

    //Dopo la generazione e memorizzazione del numero casuale,
    //si dovrà chiedere all’utente di provare ad indovinare il numero
    //specificando a video(e quindi controllando in fase di inserimento)
    //che si tratta di un numero compreso tra 1 e 100.
    //(Opzionale: Se l’utente inserisce “0” interrompe la partita e
    //gli verrà mostrato un messaggio di “Partita interrotta” quindi
    //svelato il numero che doveva indovinare.Ritornerà quindi al menu iniziale.)

    //Bisognerà tener traccia dei tentativi che fa,
    //mostrando il numero dei tentativi che sono stati fatti.

    //--------------------------------------------------------------------
    //Esempio:
    //Finora hai effettuato 0 tentativi.
    //Inserisci il tuo 1° tentativo(0 per interrompere la partita) :
    //--------------------------------------------------------------------

    //L’utente dovrà provare quindi ad indovinare il numero.
    //Ogni volta che l’utente prova ad inserire un numero, cioè inserisce un tentativo,
    //bisognerà quindi verificare se il numero inserito corrisponde al numero segreto.
    //Se l’utente NON indovina il numero, gli verrà mostrato un suggerimento del tipo
    //“Prova con un numero più alto” o “Prova con un numero più basso”
    //in base al confronto tra il numero che l’utente ha inserito e il numero segreto.
    //Quindi l’utente farà un altro tentativo e così via finché indovina il numero!

    //---------------------------------------------------------------------------------------
    //Esempio (Il numero da indovinare è 20 e l'utente inserisce come secondo tentativo 15):

    //Suggerimento: Inserisci un numero più alto.
    //Finora hai effettuato 2 tentativi.
    //Inserisci il tuo 3° tentativo (0 per interrompere la partita):
    //---------------------------------------------------------------------------------------

    //Se/quando l’utente indovina il numero, verrà visualizzato il messaggio:
    //“Complimenti hai vinto! Ti sono bastati X tentativi! Bravo!”.
    //E verrà rimandato al menu iniziale.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");
            Console.WriteLine("Inserisci il tuo nome: ");
            string name = Console.ReadLine();
            int choice;
            do
            {
                Console.WriteLine($"Ciao {name}!");
                Console.WriteLine("****Vuoi giocare? Digita [1] per giocare, [2] per uscire");
            }

            while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 2));
            if (choice == 2)
            {
                Console.WriteLine("Hai scelto di non giocare. Arrivederci!");
                return;
            }

            int numRandom = GeneraNumeroCasuale();
            MemorizzaFile(numRandom);
            CheckWin(numRandom);
            
        }

        private static void CheckWin(int numRandom)
        {
            int tentativiFatti = 0;
            Console.WriteLine($"\nProva ad indovinare il numero! Inserire un numero:   \nFinora fai effettuato {tentativiFatti} tentativi");
            while (int.TryParse(Console.ReadLine(), out int numeroInserito1) && numeroInserito1 >= 1 && numeroInserito1 <= 100)
            {
                Console.WriteLine($"Inserisci il tuo {tentativiFatti + 1}° tentativo");
                if (numeroInserito1 > numRandom)
                {
                    Console.WriteLine("Inserisci un numero più basso");
                    tentativiFatti++;
                }
                else if (numeroInserito1 < numRandom)
                {
                    Console.WriteLine("Inserisci un numero più alto");
                    tentativiFatti++;
                }
                else if (numeroInserito1 == 0)
                {
                    Console.WriteLine("Partita Interrotta!"); //dovrei usare il GOTO?

                }
                else if (numeroInserito1 == numRandom)
                    Console.WriteLine($"Complimenti, hai indovinato! Hai eseguito {tentativiFatti} tentativi!");
            }
        }

        private static void MemorizzaFile(int numRandom)
        {
            string path = @"C:\Users\Alessia\Desktop\Week2\calcolatrice_week2\Indovina Numero con Metodi\FileNumeroSegreto.txt";
            StreamWriter sw = new StreamWriter(@"NumeroSegreto.txt");
            using (StreamWriter sw1 = new StreamWriter(path))
            {
                sw1.WriteLine($"Numero da indovinare è: {numRandom}");
            }
        }

        private static int GeneraNumeroCasuale()
        {
            Random random = new Random();
            int numero = random.Next(1, 101);
            return numero;
        }
    }
}
