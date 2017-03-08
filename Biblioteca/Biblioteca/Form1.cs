using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private List<Utente> utenti;

        public Form1()
        {
            utenti = Seeder.generateUtente();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 300; i++)
            {
                UserLB.Items.Add(utenti[i].describeSeeder());
            }
        }

        Libro l = new Libro("Amore", "J.J.Reddick", "INTH232J1");
    }
}
