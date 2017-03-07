using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class Seeder
    {
        public static string generateLibro (Utente m, string cdf)
        {
            string[] nomi = {"Gionni", "Giorgio", "Russell", "Steph", "Beppe", "Giuvà", "Pino", "Arnaldo", "Gisella", "Beatrice", "Gionna", "Manuel", "LeBron", "Klay", "Maria", "Sigfrido", "Gioachino", "Brambilla", "Calogero", "Michael", "J.J.", "Luigi", "Sara", "Gregoria", "Kevin" };
            string[] cognomi = {"Lione", "Busanelli", "Ovestbrook", "Curry", "Vessicchio", "Rossi", "Abete", "Birindelli", "Pelù", "Soncini", "Mortara", "Mopu", "James", "Thompson", "Gonzaga", "Nebbiante", "Da Reggio", "Fumagalli", "Scalabrine", "Jordan", "Aradori", "Buffon", "De Gregori", "Da Lentini", "Durant" };
            string[] car = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                cdf = cdf + car[rnd.Next(0, 35)];
            }
            
            for (int i = 0; i<300; i++)
            {
                for (int l = 0; l < 9; l++)
                {
                    cdf = cdf + car[rnd.Next(0, 35)];
                }
                Utente m = new Utente(nomi[rnd.Next(0, 199)], cognomi[rnd.Next(0, 199)], cdf, 0/*NON HO CAPITO COME FUNZIONA DATETIME */ );
            }
            return /*MI SA CHE DEVO PRIMA FARE UNA LISTA DI UTENTI, DEVO LAVORARCI ANCORA */; 
        }
    }
}
