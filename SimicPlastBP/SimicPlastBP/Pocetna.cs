using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimicPlastBP
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }
        

        private void btnProzori_Click(object sender, EventArgs e)
        {
            Prozori1 prozori = new Prozori1();
            this.Hide();
            prozori.Show();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            UnosKupca unosKupca = new UnosKupca();
            this.Hide();
            unosKupca.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            PregledKupaca pregledKupaca = new PregledKupaca();
            this.Hide();
            pregledKupaca.Show();
        }

        private void btnRoletne_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ova funkcija je u fazi razvoja.");
        }

        private void btnKomarnici_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ova funkcija je u fazi razvoja.");
        }

        private void btnVrata_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ova funkcija je u fazi razvoja.");
        }
    }
}
