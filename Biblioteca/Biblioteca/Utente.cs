using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    class Utente
    {
        private string _nome;
        public string nome { get { return _nome; } }

        private string _cognome;
        public string cognome { get { return _cognome; } }

        private string _codFisc;
        public string codFisc { get { return _codFisc; } }

        private DateTime _dataNascita;
        public DateTime dataNascita { get; set; }

        //public List<Libro> = libriUtente;

        public Utente (string nome, string cognome, string codFisc, DateTime dataNascita)
        {
            _nome = nome;
            _cognome = cognome;
            _codFisc = codFisc;
            _dataNascita = dataNascita;

        }

        public override string ToString()
        {
            return (nome + ", " + cognome + ", " + dataNascita + ".");
        }

        public string describe()
        {
            string output = "Nome: " + nome + ";\r\n";
                   output += "Cognome: "+ cognome + ";\r\n";
                   output += "Data di Nascita: " + dataNascita + ";\r\n";
                   output += "Codice Fiscale: " + codFisc + ";\r\n";
                   output += "Numero di libri posseduti: " + "(Index lista libriUtente)" + ";\r\n";

            return output;
        }

        public string describeLibriUtente()
        {
            string output = "Descrizione lista libriUtente";
            return output;
        }
    }
}
