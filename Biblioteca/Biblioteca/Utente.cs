using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Utente
    {
        private string _nome;
        public string nome { get; set; }

        private string _cognome;
        public string cognome { get; set; }

        private string _codFisc;
        public string codFisc { get; set; }

        private DateTime _dataNasc;
        public DateTime dataNasc { get; set; }

        public string describe()
    }
}
