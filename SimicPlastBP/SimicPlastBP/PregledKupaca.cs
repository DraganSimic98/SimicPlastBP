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
    public partial class PregledKupaca : Form
    {
        public PregledKupaca()
        {
            InitializeComponent();
        }

        private void PregledKupaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kupciDataSet.Pregled_Kupaca' table. You can move, or remove it, as needed.
            this.pregled_KupacaTableAdapter.Fill(this.kupciDataSet.Pregled_Kupaca);

        }

        private void btnPocetna2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            KupciDataSet.Pregled_KupacaDataTable tabelaKupca = kupciDataSet.Pregled_Kupaca;
            if (txtBrojTelefona1.Text != "")
            {
                tabelaKupca = pregled_KupacaTableAdapter.PretragaKupaca(txtBrojTelefona1.Text);
            }
            dataGridView1.DataSource = tabelaKupca;
        }

        private void btnObrisi1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete kupca?",
                "Brisanje kupca", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.No)
            {
                return;
            }

            string ime = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            pregled_KupacaTableAdapter.ObrisiKupca(ime);
            pregled_KupacaTableAdapter.Fill(kupciDataSet.Pregled_Kupaca);
            MessageBox.Show("Uspesno ste obrisali kupca");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
