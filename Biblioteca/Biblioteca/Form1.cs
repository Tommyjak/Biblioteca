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
        private List<Libro> libri;
        public Form1()
        {
            libri = Seeder.generateLibro();
            utenti = Seeder.generateUtente();
            //Seeder.associa();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 300; i++)
            {
                UserLB.Items.Add(utenti[i].ToString());
            }

            for (int i = 0; i < 100; i++)
            {
                /*if (libri[i].prestatoLibro == false)
                {
                    //scrivi in rosso
                }*/
                BookLB.Items.Add(libri[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (BookLB.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare almeno un libro", "Selezionare un libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Libro b = libri[BookLB.SelectedIndex] as Libro;
                infoBox.Text = b.describeLibro();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserLB.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare almeno un utente", "Selezionare un utente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Utente u = utenti[UserLB.SelectedIndex] as Utente;
                infoBox.Text = u.describeUtente();
                return;
            }
        }

        private void prestaButt_Click(object sender, EventArgs e)
        {
            if (BookLB.SelectedIndex == -1 || UserLB.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un utente e un libro", "Selezionare un utente e un libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Utente u = utenti[UserLB.SelectedIndex] as Utente;
                    Libro b = libri[BookLB.SelectedIndex] as Libro;
                    PrestaOut.Text = b.presta(u);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //string output = libri[BookLB.SelectedIndex] + "è stato prestato a " + utenti[UserLB.SelectedIndex];
        }
    }
}
