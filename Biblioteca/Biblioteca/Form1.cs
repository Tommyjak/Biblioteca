﻿using System;
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
        private List<Libro> libriPosseduti;
        private List<Utente> utenti;
        private List<Libro> libri;
        public Form1()
        {
            libri = Seeder.generateLibro();
            utenti = Seeder.generateUtente(libri);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 300; i++)
            {
                UserLB.Items.Add(utenti[i].describeSeeder());
            }
        }

        //Libro l = new Libro("Amore", "J.J.Reddick", "INTH232J1"); *solo di prova*

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BookLB.Items.Add(libri[i].describeSeeder());
            }
        }

        private void UserLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookLB.Items.Add(utenti[UserLB.SelectedIndex].libriPosseduti);
        }


        /* private void button3_Click(object sender, EventArgs e)
        {
            BookLB.SelectedItem.
        }*/
    }
}
