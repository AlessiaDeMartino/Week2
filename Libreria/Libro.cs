using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public Genere Genere { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataPubblicazione { get; set; }


        //COSTRUTTORE -> Costruire oggetti libro.
        public Libro()
         {

         }

     }
    public enum Genere
        {
            Narrativa=1,
            Storico=2,
            Fantasy=3
        }
}
