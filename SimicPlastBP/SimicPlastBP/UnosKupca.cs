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
    public partial class UnosKupca : Form
    {
        public UnosKupca()
        {
            InitializeComponent();
        }
        private void UnosKupca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kupciDataSet.Pregled_Kupaca' table. You can move, or remove it, as needed.
            this.pregled_KupacaTableAdapter.Fill(this.kupciDataSet.Pregled_Kupaca);

        }

        private void btnPocetna1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Unesite ime kupca");
                return;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Unesite prezime kupca");
                return;
            }
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                MessageBox.Show("Unesite adresu kupca");
                return;
            }
            if (string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Unesite telefon kupca");
                return;
            }
            if (string.IsNullOrEmpty(cbProizvod.SelectedItem.ToString()))
            {
                MessageBox.Show("Odaberite proizvod");
                return;
            }
            if (string.IsNullOrEmpty(txbSirina.Text))
            {
                MessageBox.Show("Unesite sirinu");
                return;
            }
            if (string.IsNullOrEmpty(txtVisina1.Text))
            {
                MessageBox.Show("Unesite visinu");
                return;
            }
            if (string.IsNullOrEmpty(cbMaterijal.SelectedItem.ToString()))
            {
                MessageBox.Show("Odaberite materijal");
                return;
            }
            if (string.IsNullOrEmpty(cbTip.SelectedItem.ToString()))
            {
                MessageBox.Show("Odaberite tip");
                return;
            }
            var result = pregled_KupacaTableAdapter.UzmiBrojOdKupca(txtTel.Text);
            if ((int)result == 1)
            {
                MessageBox.Show("Vec postoji kupac sa tim brojem telefona");
                return;
            }

            pregled_KupacaTableAdapter.UnesiKupca( txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTel.Text, cbProizvod.SelectedItem.ToString(), txbSirina.Text, txtVisina1.Text, cbMaterijal.SelectedItem.ToString(), cbTip.SelectedItem.ToString(), dtpPorudzbina.Value.ToString(), dtpUgradnja.Value.ToString(), txtCena.Text);
            pregled_KupacaTableAdapter.Fill(kupciDataSet.Pregled_Kupaca);

            txtIme.Text = string.Empty;
            txtPrezime.Text = string.Empty;
            txtAdresa.Text = string.Empty;
            txtTel.Text = string.Empty;
            cbProizvod.Text = string.Empty;
            txbSirina.Text = string.Empty;
            txtVisina1.Text = string.Empty;
            cbMaterijal.Text = string.Empty;
            cbTip.Text = string.Empty;
            txtCena.Text = string.Empty;
            dtpPorudzbina.Value = DateTime.Now;
            dtpUgradnja.Value = DateTime.Now;
            MessageBox.Show("Uspesno ste uneli kupca");
        }

        private void btnPretraga1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledKupaca pretraga = new PregledKupaca();
            pretraga.Show();

        }
    }
}
