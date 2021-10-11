using System;

namespace calcolatrice_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Questo programma sarà una calcolatrice!");
            Console.WriteLine("Come ti chiami?");
            string nomeUtente;
            nomeUtente = Console.ReadLine();
            Console.WriteLine($"Ciao {nomeUtente}");
            bool continua = false;
            do
            {
                int primoNumero;
                //primoNumero = int.Parse(Console.ReadLine());
                // bool esitoConversione = int.TryParse(Console.ReadLine(), out primoNumero); //NON VA IN ECCEZIONE, prova a convertire. 
                //Se non riesce, di default stampa 0. TryParse rende FALSO. 


                //while (esitoConversione == false)
                //{
                //    Console.WriteLine("Hai inserito un valore errato: inserisci un numero intero");
                //    esitoConversione = int.TryParse(Console.ReadLine(), out primoNumero);
                //}
                //entro nel while quando ciò che è nelle parentesi è VERO.


                do
                {
                    Console.WriteLine("Inserisci il primo numero intero:");
                }
                while (!int.TryParse(Console.ReadLine(), out primoNumero));
                //OPPURE: while(int.TryParse(Console.ReadLine(),out primoNumero)==false);
                //entra nel do fino a quando si verifica ciò che è nel while.
                //mi chiede di inserire il numero intero finchè non metto davvero un numero intero. 
                // SE metto un numero, l'intTryPare è vero, con il ! diventa falso e non reinserisco il numero, va bene così. uscire.
                // SE metto un carattere,non va bene,devo rifare il do, quindi il while(VERO) -> intTryParse=falso. con ! FeF=V
                //richiedo di rifare il do. 
                Console.WriteLine($"Il primo numero che hai inserito è: {primoNumero}");
                int secondoNumero;
                do
                {
                    Console.WriteLine("Inserisci il secondo numero intero:");
                }
                while (!int.TryParse(Console.ReadLine(), out secondoNumero));
                Console.WriteLine($"Il secondo numero che hai inserito è: {secondoNumero}");
                Console.WriteLine($"I numeri che hai inserito sono: {primoNumero} e {secondoNumero}");
                Console.WriteLine("----Menù----");
                Console.WriteLine("Scegli A per fare la somma");
                Console.WriteLine("Scegli B per fare la differenza");
                Console.WriteLine("Scegli C per fare il prodotto");
                Console.WriteLine("Scegli D per fare il quoziente");
                //Console.WriteLine("Fai la tua scelta");
                char sceltaUtente;
                do
                {
                    Console.WriteLine("Fai la tua scelta");
                    sceltaUtente = Console.ReadKey().KeyChar;
                } while (!(sceltaUtente.ToString().ToUpper() == "A" || sceltaUtente.ToString().ToUpper() == "B" || sceltaUtente.ToString().ToUpper() == "C" || sceltaUtente.ToString().ToUpper() == "D"));

                Console.WriteLine($"La tua scelta è {sceltaUtente}");

                switch (sceltaUtente.ToString().ToUpper())
                {
                    case "A":
                        //int somma;
                        //somma = primoNumero + secondoNumero;
                        int somma = Somma(primoNumero, secondoNumero);
                        Console.WriteLine($"La somma dei due numeri è: {somma}");
                        break;
                    case "B":
                        //int differenza;
                        //differenza = primoNumero - secondoNumero;
                        int differenza = Sottrai(primoNumero, secondoNumero);
                        Console.WriteLine($"La differenza dei due numeri è: {differenza}");
                        //oppure Console.WriteLine($"La differenza dei due numeri è: {primoNumero-secondoNumero}");
                        break;
                    case "C":
                        //int prodotto;
                        //prodotto = primoNumero * secondoNumero;
                        int prodotto = Moltiplica(primoNumero, secondoNumero);
                        Console.WriteLine($"Il prodotto dei due numeri è: {prodotto}");
                        break;
                    case "D":
                        if (secondoNumero == 0)
                        {
                            Console.WriteLine("Impossibile!");
                        }

                        else
                        {
                            Dividi(primoNumero, secondoNumero);
                        }
                        // se ho 3 me lo trasforma 3.0. Perchè sennò
                        //                                                     //sarebbe stata una divisione tra numeri interi! 
                        //    Console.WriteLine($"Il quoziente dei due numeri è: {quoziente}");
                        //}
                        break;
                }
                Console.WriteLine("Vuoi continuare?Inserire SI per continuare, qualsiasi altra cosa per uscire");
                string rispostaUtente = Console.ReadLine();
                if (rispostaUtente.ToLower() == "si")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }
            } while (continua);



        }
        private static int Somma(int x, int y)
        {
            int somma = x + y;
            return somma;
        }
        private static int Sottrai(int x, int y)
        {
            int differenza = x - y;
            return differenza;
        }
        private static int Moltiplica(int x, int y)
        {
            int prodotto = x * y;
            return prodotto;
        }
        private static double Dividi(int x, int y)
        {
            double quoziente;
            quoziente = (double)x / y;
            Console.WriteLine($"Il quoziente dei due numeri è: {quoziente}");
            return quoziente;
        }
    }
}
