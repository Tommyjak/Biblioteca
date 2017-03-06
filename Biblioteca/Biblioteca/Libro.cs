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
    }
}
