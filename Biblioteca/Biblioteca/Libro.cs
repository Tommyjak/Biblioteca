using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    class Libro
    {
        //string[] generiLibro = { "fantasy", "rosa", "avventura", "bambini", "classico", "giallo", "thriller", "horror" };
        private Utente _possessore;
        public Utente possessore { get { return _possessore; } }

        private string _titolo;
        public string titolo { get { return _titolo; } }

        private string _autore;
        public string autore { get { return _autore; } }

        private genere _genere;
        public enum genere { fantasy, rosa, avventura, bambini, classico, giallo, thriller, horror }

        private string _isbn;
        public string isbn { get { return _isbn; } }

        private Boolean _prestatoLibro;
        public Boolean prestatoLibro { get { return _prestatoLibro; } }

        Random rnd = new Random();

        public Libro(string titolo, string autore, string isbn, genere myGenere)
        {
            _titolo = titolo;
            _autore = autore;
            _isbn = isbn;
            _genere = myGenere;
            _prestatoLibro = true;
            //Console.WriteLine(describeLibro());
        }

        /*public string describeSeeder()
        {
            string output = titolo + " / " + autore + " / " + isbn + " / " + _genere;
            return output; // errore del codice fiscale da discutere e della data di nascita che fatico a comprendere.
        }*/

        public override string ToString()
        {
            return (titolo + " ");
        }

       /* public void assignGenere()
        {
            genere g;
            string genereString;

            switch (g)
            {

            }
        }*/

        public string describeLibro()
        {
            string output = "TITOLO: " + titolo + System.Environment.NewLine;
                   output += "AUTORE: " + autore + System.Environment.NewLine;
                   output += "GENERE: " + _genere + System.Environment.NewLine;
                   output += "ISBN: " + isbn + System.Environment.NewLine;

            return output;
        }

        public string presta(Utente u)
        {
            string output; 

            if (prestatoLibro == false)
            {
                throw new Exception("Il libro è già stato prestato");
            }
            if (u.libriPosseduti.Count >= 6)
            {
                throw new Exception("L'utente ha già raggiunto il numero massimo di libri ");
            }

            _possessore = u;
            _prestatoLibro = false;
            _possessore.libriPosseduti.Add(this);
            output = ("Il prestito è andato a buon fine per l'utente " + _possessore.nome)+ System.Environment.NewLine + _possessore.describeLibriUtente();
            

            return output;
        }
     


    }
}
