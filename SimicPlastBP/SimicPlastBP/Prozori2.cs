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
    public partial class Prozori2 : Form
    {
        public static string materijal;
        public Prozori2()
        {
            InitializeComponent();
        }

        

        

        

        private void btnNapred_Click_1(object sender, EventArgs e)
        {
            if (rbAlu.Checked)
            {
                materijal = "ALU";
            }
            else
            {
                materijal = "PVC";
            }
            Prozori3 prozori3 = new Prozori3();
            this.Hide();
            prozori3.Show();
        }

        private void btnOtkazi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void btnNazad_Click_1(object sender, EventArgs e)
        {
            Prozori1 prozori1 = new Prozori1();
            this.Hide();
            prozori1.Show();

        }
    }
}
