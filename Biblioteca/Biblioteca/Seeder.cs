using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class Seeder
    {
        private static string cdf;

        public static List<Utente> generateUtente()
        {
            List<Utente> utenti = new List<Utente>();

            string[] nomi = {"Gionni", "Giorgio", "Russell", "Steph", "Beppe", "Giuvà", "Pino", "Arnaldo", "Gisella", "Beatrice", "Gionna", "Manuel", "LeBron", "Klay", "Maria", "Sigfrido", "Gioachino", "Brambilla", "Calogero", "Michael", "J.J.", "Luigi", "Sara", "Gregoria", "Kevin" };
            string[] cognomi = {"Lione", "Busanelli", "Ovestbrook", "Curry", "Vessicchio", "Rossi", "Abete", "Birindelli", "Pelù", "Soncini", "Mortara", "Mopu", "James", "Thompson", "Gonzaga", "Nebbiante", "Da Reggio", "Fumagalli", "Scalabrine", "Jordan", "Aradori", "Buffon", "De Gregori", "Da Lentini", "Durant" };
            string[] car = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random rnd = new Random();//Secondo me andrebbe messo dentro il ciclo per la formazione delle varie cose perchè venggono tutti uguali (tommi)
            DateTime nasc = new DateTime(rnd.Next(1940,2002),rnd.Next(1,12),rnd.Next(1,28));

            for (int l = 0; l < 9; l++)
            {
                cdf = cdf + car[rnd.Next(0, 35)];
            }

            for (int i = 0; i<300; i++)
            {                
                utenti.Add (new Utente (nomi[rnd.Next(0, 24)], cognomi[rnd.Next(0, 24)], cdf, nasc));                
            }
            return utenti; 
        }
    }
}
