using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private string _titolo;
        public string titolo { get; set; }

        private string _autore;
        public string autore { get; set; }

        private string _genere;
        public string genere { get; set; }

        private string _isbn;
        public string isbn { get; set; }

        private Boolean _prestatoLibro;
        public Boolean prestatoLibro {get {return }}//devo ancora guardare bene come si fa 

        public Libro(string titolo, string autore, string genere, string isbn)
        {
            _titolo = titolo;
            _autore = autore;
            _genere = genere;
            _isbn = isbn;
        }

        public override string ToString()
        {
            return (titolo + "," + autore + "," + isbn);
        }

        public string describeLibro()
        {
            string output = "TITOLO: " + titolo;
                   output += "AUTORE: " + autore;
                   output += "GENERE: " + genere;
                   output += "ISBN: " + isbn;

            return output;
        }

        public void presta(Utente u)
        {
            Boolean pl = true;

            if (pl == true)
            {
                Console.WriteLine("Il prestito è andato a buon fine!");
            }
            else
            {
                Console.WriteLine("Spiacenti, il libro selezionato è già stato prestato a"(/*utente che ha già il libro*/));
            }
        }


    }
}
