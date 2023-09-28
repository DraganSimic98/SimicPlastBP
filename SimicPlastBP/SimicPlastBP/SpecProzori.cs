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
    public partial class SpecProzori : Form
    {
        public static double cena;
        public double pvcJedno = 70;
        public double pvcDvo = 140;
        public double aluJedno = 140;
        public double aluDvo = 140;
        public double pokvadratu;

        public SpecProzori()
        {
            InitializeComponent();
        }

        private void SpecProzori_Load_1(object sender, EventArgs e)
        {
            if (Prozori2.materijal == "ALU" && Prozori3.tip == "Jednokrilni")
            {
                cena = 140;
            }
            else if (Prozori2.materijal == "ALU" && Prozori3.tip == "Dvokrilni")
            {
                cena = 140;
            }
            else if (Prozori2.materijal == "PVC" && Prozori3.tip == "Jednokrilni")
            {
                cena = 70;
            }
            else if (Prozori2.materijal == "PVC" && Prozori3.tip == "Dvokrilni")
            {
                cena = 140;
            }

            lblTip.Text = Prozori3.tip;
            lblMaterijal.Text = Prozori2.materijal;
            lblDimenzije.Text = Prozori1.sirina.ToString() + " x " + Prozori1.visina.ToString();
            lblCena.Text = (Prozori1.kvadrata * cena).ToString() + " evra";
        }
        

          

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

       
    }
}
