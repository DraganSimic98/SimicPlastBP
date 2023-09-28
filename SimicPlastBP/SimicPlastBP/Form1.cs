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
    public partial class Form1 : Form
    {
        public string username = "123";
        public string password = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == username && txtPass.Text == password)
            {
                this.Hide();
                Pocetna pocetna = new Pocetna();
                pocetna.Show();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke.");
            }
        }
    }
}
