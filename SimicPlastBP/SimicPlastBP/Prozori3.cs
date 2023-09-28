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
    public partial class Prozori3 : Form
    {
        public static string tip;
        public Prozori3()
        {
            InitializeComponent();
        }


        private void btnNapred_Click_1(object sender, EventArgs e)
        {
            if (rbJednokrilni.Checked)
            {
                tip = "Jednokrilni";
            }
            else
            {
                tip = "Dvokrilni";
            }

            SpecProzori prozoriSpec = new SpecProzori();
            this.Hide();
            prozoriSpec.Show();

        }

        private void btnOtkazi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void btnNazad_Click_1(object sender, EventArgs e)
        {
            Prozori2 prozori2 = new Prozori2();
            this.Hide();
            prozori2.Show();
        }
    }
}
