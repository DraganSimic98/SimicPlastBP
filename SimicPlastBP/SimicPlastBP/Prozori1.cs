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
    public partial class Prozori1 : Form
    {
        public static double sirina;
        public static double visina;
        public static double kvadrata;

        public Prozori1()
        {
            InitializeComponent();
        }

      


        private void TxtSirina_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void TxtVisina_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void TxtSirina_Leave(object sender, EventArgs e)
        {
            if (Double.Parse(txtSirina.Text) < 600 || Double.Parse(txtSirina.Text) > 2000)
            {
                MessageBox.Show("Obratite pažnju na dozvoljene mere.");
            }
        }

        private void TxtVisina_Leave_1(object sender, EventArgs e)
        {
            if (Double.Parse(txtSirina.Text) < 600 || Double.Parse(txtSirina.Text) > 2200)
            {
                MessageBox.Show("Obratite pažnju na dozvoljene mere.");
            }
        }

        private void txtSirina_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNapred_Click_1(object sender, EventArgs e)
        {
            sirina = Double.Parse(txtSirina.Text);
            visina = Double.Parse(txtVisina.Text);
            kvadrata = (sirina * visina) / 1000000;

            this.Hide();
            Prozori2 prozori2 = new Prozori2();
            prozori2.Show();

        }

        private void btnOtkazi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();

        }

        private void Prozori1_Load(object sender, EventArgs e)
        {

        }
    }
}
