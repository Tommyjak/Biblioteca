using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    class Utente
    {
        public List<Libro> libriPosseduti= new List<Libro>();

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
            return (nome + " " + cognome );
        }


        /*public string describeSeeder()
        {
            string output = nome + " " + cognome + " " + dataNascita.Date + " " + codFisc + " " + "Numero di libri posseduti: " + "(Index lista libriUtente)";
            return output; // errore del codice fiscale da discutere e della data di nascita che fatico a comprendere.
        }*/

        public string describeUtente()
        {
            string output = "Nome: " + nome + ";"+ System.Environment.NewLine;
                   output += "Cognome: "+ cognome + ";" + System.Environment.NewLine;
                   output += "Data di Nascita: " + dataNascita.ToShortDateString() + ";" + System.Environment.NewLine;
                   output += "Codice Fiscale: " + codFisc + ";" + System.Environment.NewLine;
                   output += "Numero di libri posseduti: " + "(Index lista libriUtente)" + ";" + System.Environment.NewLine;

            return output;
        }

        public string describeLibriUtente()
        {
            int j = libriPosseduti.Count;

            string output = this.ToString() + " possiede i seguenti libri: " + System.Environment.NewLine;
            for (int i=0; i < j; i++)
            {
                output += libriPosseduti[i].ToString()+ System.Environment.NewLine;
            }
            return output;
        }
    }
}
