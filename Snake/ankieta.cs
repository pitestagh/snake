﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ankietaklasa ankieta = new ankietaklasa(richTextBox2.Text);
            ankieta.dodajwiadomosc();
            Menustart menu1 = new Menustart();
            menu1.Show();
            this.Hide();
        }
    }
}
