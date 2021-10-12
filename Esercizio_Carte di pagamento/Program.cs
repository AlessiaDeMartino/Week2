using System;

namespace Esercizio_Carte_di_pagamento
{
    class Program
    {
        // Le carte di pagamento sono lunghe 16 cifre.
        // Le prime 6 cifre rappresentano un numero di identificazione univoco per la banca che ha emesso la carta.
        // Le successive 2 cifre determinano il tipo di carta (ad es. debito, credito, regalo).
        // Le cifre da 9 a 15 sono il numero di serie della carta
        // L'ultima cifra è utilizzata come cifra di controllo per verificare se il numero della carta è valido.

        // Hans Peter ha inventato un metodo per determinare se un numero di carta di credito è sintatticamente valido

        // Step 1 : Vengono raddoppiate le cifre che si trovano in posizione dispari
        // Step 2 : Se questo "raddoppio" risulta in un numero a due cifre, viene sottratto 9 da esso per ottenere una sola cifra.
        // Step 3 : Vengono sommante tutte le cifre ottenute
        // Step 4 : Vengono aggiunte le cifre nelle posizioni pari
        // Step 5 : Se il risultato è divisibile per 10, il numero della carta è valido; in caso contrario, non è valido.

        // Esempi
        // Carta di pagamento : 4 5 5 6 7 3 7 5 8 6 8 9 9 8 5 5
        // Step 1 : 8 5 10 6 14 3 14 5 16 6 16 9 18 8 10 5
        // Step 2 : 8 5 1 6 5 3 5 5 7 6 7 9 9 8 1 5
        // Step 3 : 8 + 1 + 5 + 5 + 7 + 7 + 9 + 1 = 43
        // Step 4 : 43 + (5+6+3+5+6+9+8+5) = 43 + 47 = 90
        // Step 5 : 90/10 = 9 resto 0 -> Numero della carta valido

        // Esempi
        // Carta di pagamento : 4 0 2 4 0 0 7 1 0 9 0 2 2 1 4 3
        // Step 1 : 8 0 4 4 0 0 14 1 0 9 0 2 4 1 8 3
        // Step 2 : 8 0 4 4 0 0 5 1 0 9 0 2 4 1 8 3
        // Step 3 : 8 + 4 + 0 + 5 + 0 + 0 + 4 + 8 = 29
        // Step 4 : 29 + (0+4+0+1+9+2+1+3) = 29 + 20 = 49
        // Step 5 : 49/10 = 4 resto 9 -> Numero della carta non valido
        static void Main(string[] args)
        { //int N=16;
            //int [] cartaCredito= new int[N];
            //for (int i=0; i<N.Lenghth; i++)
            //{
            //int numero;
            //Console.WriteLine("Inserisci il {i+1}° numero della carta:")
            //while (!(int.TryParse(Console.ReadLine(), out numero))
            //{ Console.WriteLine("Inserisci un numero valido:") }
            // cartaCredito[i]=numero;
           // } 
            //Console.WriteLine("Inserire le 16 cifre della carta di pagamento");
            int [] carta= new int [] {4,5,5,6,7,3,7,5,8,6,8,9,9,8,5,5};
            int[] posizionePari = new int[8];
            int[] posizioneDispari = new int[8];
            int[] raddoppioPosizioneDispari = new int[8];
            
            posizioneDispari = TrovaPosizioniDispari (carta, ref posizioneDispari);           
            raddoppioPosizioneDispari = Raddoppia(posizioneDispari, ref raddoppioPosizioneDispari);                      
            int [] diff = Sottrai (raddoppioPosizioneDispari); 
                        
            int addizione_dispari = SommaDispari(diff);
            posizionePari = TrovaPosizioniPari(carta, ref posizionePari);
            
            int addizione_pari = SommaPari(posizionePari);
            int SommaTot = 0;
            SommaTot = addizione_dispari + addizione_pari;
            CheckCarta(SommaTot);
        }

        private static int SommaDispari(int[] posizionidispari)
        {
            int add = 0;
            for (int i = 0; i < posizionidispari.Length; i++)
            {
                add = add + posizionidispari[i];
            }
            return add;

        }
        private static int[] Raddoppia(int[] posizionedispari, ref int[] raddoppioPosizioneD)
        {
            for (int i = 0; i < posizionedispari.Length; i++)
            {

                raddoppioPosizioneD[i] = posizionedispari[i] * 2;
            }
            return raddoppioPosizioneD;
        }
        private static int [] TrovaPosizioniDispari (int [] numericarta, ref int[] arrayPosizioneDispari)
        {
            int cont = 0;
           for (int i = 0; i < numericarta.Length; i = i + 2)
           {
                arrayPosizioneDispari[cont] = numericarta[i];
                cont++;
            }
            return arrayPosizioneDispari;
        }
        private static int [] Sottrai (int[] raddoppio)
        {            
            int[] newArray = new int [raddoppio.Length];

            for (int i=0; i < raddoppio.Length; i++)
            {
                if (raddoppio[i] > 9)
                {
                    newArray[i] = (raddoppio[i] - 9); //non lo fa! Quando fa 10-9-> rende 0 anzichè 1. 
                    
                }
                else if (raddoppio[i] < 10)
                {
                    newArray[i] = raddoppio[i];
                }
                //Array.Resize(ref newArray, cont);
            }
             return newArray;

        }
        private static int[] TrovaPosizioniPari(int[] numericarta, ref int[] arrayPosizionePari)
        {
            int cont = 0;
            for (int i = 1; i <= numericarta.Length; i =i+2 )
            {
                arrayPosizionePari[cont] = numericarta[i];
                cont++;
            }
            return arrayPosizionePari;
        }
        private static int SommaPari(int[] posizionipari)
        {
            int add = 0;
            for (int i = 0; i < posizionipari.Length; i++)
            {
                add = add + posizionipari[i];
            }
            return add;

        }
        private static void CheckCarta(int Sommatotale)
        {

            if ((Sommatotale % 10) == 0)
            {

                Console.WriteLine("Numero Carta Valido!");
            }


            else
            {
                Console.WriteLine("Numero Carta NON Valido!");
            }

            
                 
        }
    }
}
