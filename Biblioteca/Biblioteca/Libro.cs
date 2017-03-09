using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        //string[] generiLibro = { "fantasy", "rosa", "avventura", "bambini", "classico", "giallo", "thriller", "horror" };

        private string _titolo;
        public string titolo { get { return _titolo; } }

        private string _autore;
        public string autore { get { return _autore; } }

        public enum genere { fantasy, rosa, avventura, bambini, classico, giallo, thriller, horror }

        private string _isbn;
        public string isbn { get { return _isbn; } }

        private Boolean _prestatoLibro;
        //public Boolean prestatoLibro {get { return; }}//devo ancora guardare bene come si fa 

        public Libro(string titolo, string autore, string isbn)
        {
            _titolo = titolo;
            _autore = autore;
            _isbn = isbn;
            Console.WriteLine(describeLibro());
        }

        public string describeSeeder()
        {
            string output = titolo + " / " + autore + " / " + isbn;
            return output; // errore del codice fiscale da discutere e della data di nascita che fatico a comprendere.
        }

        public override string ToString()
        {
            return (titolo + "," + autore + "," + isbn);
        }

        public string describeLibro()
        {
            string output = "TITOLO: " + titolo + "\r\n";
                   output += "AUTORE: " + autore + "\r\n";
                   output += "GENERE: " + genere.avventura + "\r\n";//devo finire di guardare l'enum
                   output += "ISBN: " + isbn + "\r\n";

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
                //Console.WriteLine("Spiacenti, il libro selezionato è già stato prestato a"(/*utente che ha già il libro*/));
            }
        }


    }
}
