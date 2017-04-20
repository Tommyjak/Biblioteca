using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class Seeder
    {
        private static string cod;
        private static List<Utente> listaUtenti = new List<Utente>();
        private static List<Libro> listaLibri = new List<Libro>();


        public static List<Utente> generateUtente()
        {
            List<Utente> utenti = new List<Utente>();
            Utente utente;

            string[] nomi = { "Gionni", "Giorgio", "Russell", "Steph", "Beppe", "Giuvà", "Pino", "Arnaldo", "Gisella", "Beatrice", "Gionna", "Manuel", "LeBron", "Klay", "Maria", "Sigfrido", "Gioachino", "Brambilla", "Calogero", "Michael", "J.J.", "Luigi", "Sara", "Gregoria", "Kevin" };
            string[] cognomi = { "Leone", "Busanelli", "Ovestbrook", "Curry", "Vessicchio", "Rossi", "Abete", "Birindelli", "Pelù", "Soncini", "Mortara", "Mopu", "James", "Thompson", "Gonzaga", "Nebbiante", "Da Reggio", "Fumagalli", "Scalabrine", "Jordan", "Aradori", "Buffon", "De Gregori", "Da Lentini", "Durant" };
            string[] caratteri = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Random rnd = new Random();

            for (int i = 0; i < 300; i++)
            {
                cod = "";
                for (int l = 0; l < 9; l++)
                {
                    cod += caratteri[rnd.Next(0, 36)];
                }
                DateTime nasc = new DateTime(rnd.Next(1940, 2002), rnd.Next(1, 12), rnd.Next(1, 28));
                Console.WriteLine(nasc.ToShortDateString());
                utente = new Utente(nomi[rnd.Next(0, 25)], cognomi[rnd.Next(0, 25)], cod,nasc);
                utenti.Add(utente);
                listaUtenti.Add(utente);

            }
            return utenti;

        }

        public static List<Libro> generateLibro()
        {
            List<Libro> libri = new List<Libro>();
            Libro libro;

            string[] titoli1 = { "Il vecchio", "La palla", "Il Gabbiano", "La Peppa", "Beppe", "Giorgio Mastrota", "LeBron James", "Gianni morandi", "Manuel Mopu", "Il cacciavite" };
            string[] titoli2 = { " dorme", " rimbalza", " starnazza", " sputa fuoco", " sussurra ai sassi", " e la padella", " schiaccia", " e la chitarra di ghisa", " e la piallatrice" };
            string[] autori = { "Giacomo Leopardi", "Anonimo", "Dante Alighieri", "Piero Angela", "Francesco Petrarca", "Salvatore Aranzulla", "Giulio Cesare", "Socrate", "Ciro Immobile", "Tommaso Mortara" };
            string[] numeri = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random rnd = new Random();

            int numGeneri = Enum.GetNames(typeof(Libro.genere)).Length;
            Random genereInd = new Random();

            for (int i = 0; i < 100; i++)
            {
                cod = "";
                int k = genereInd.Next(numGeneri);
                Libro.genere myGenere = (Libro.genere)k;

                for (int l = 0; l < 13; l++)
                {
                    Random car = new Random();

                    cod = cod + numeri[rnd.Next(0, 10)];
                }
                libro = new Libro(titoli1[rnd.Next(0, 9)] + titoli2[rnd.Next(0, 9)], autori[rnd.Next(0, 9)], cod, myGenere);
                libri.Add(libro);
                listaLibri.Add(libro);
            }
            return libri;
        }
    }
}
