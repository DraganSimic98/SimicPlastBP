namespace SimicPlastBP
{
    partial class PregledKupaca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBrojTelefona1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPocetna2 = new System.Windows.Forms.Button();
            this.pregledKupacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.širinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPorudžbineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUgradnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregledKupacaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kupciDataSet = new SimicPlastBP.KupciDataSet();
            this.gbPregled = new System.Windows.Forms.GroupBox();
            this.btnObrisi1 = new System.Windows.Forms.Button();
            this.pregled_KupacaTableAdapter = new SimicPlastBP.KupciDataSetTableAdapters.Pregled_KupacaTableAdapter();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataSet)).BeginInit();
            this.gbPregled.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrojTelefona1
            // 
            this.txtBrojTelefona1.Location = new System.Drawing.Point(6, 43);
            this.txtBrojTelefona1.Name = "txtBrojTelefona1";
            this.txtBrojTelefona1.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTelefona1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj telefona";
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.txtBrojTelefona1);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Location = new System.Drawing.Point(19, 32);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(192, 83);
            this.gbPretraga.TabIndex = 5;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Kriterijumi pretrage";
            // 
            // btnPocetna2
            // 
            this.btnPocetna2.Location = new System.Drawing.Point(12, 478);
            this.btnPocetna2.Name = "btnPocetna2";
            this.btnPocetna2.Size = new System.Drawing.Size(75, 23);
            this.btnPocetna2.TabIndex = 4;
            this.btnPocetna2.Text = "Pocetna";
            this.btnPocetna2.UseVisualStyleBackColor = true;
            this.btnPocetna2.Click += new System.EventHandler(this.btnPocetna2_Click);
            // 
            // pregledKupacaBindingSource
            // 
            this.pregledKupacaBindingSource.DataMember = "Pregled_Kupaca";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(19, 121);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.proizvodDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.širinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.datumPorudžbineDataGridViewTextBoxColumn,
            this.datumUgradnjeDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pregledKupacaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            // 
            // proizvodDataGridViewTextBoxColumn
            // 
            this.proizvodDataGridViewTextBoxColumn.DataPropertyName = "Proizvod";
            this.proizvodDataGridViewTextBoxColumn.HeaderText = "Proizvod";
            this.proizvodDataGridViewTextBoxColumn.Name = "proizvodDataGridViewTextBoxColumn";
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "Visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina";
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            // 
            // širinaDataGridViewTextBoxColumn
            // 
            this.širinaDataGridViewTextBoxColumn.DataPropertyName = "Širina";
            this.širinaDataGridViewTextBoxColumn.HeaderText = "Širina";
            this.širinaDataGridViewTextBoxColumn.Name = "širinaDataGridViewTextBoxColumn";
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "Materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // datumPorudžbineDataGridViewTextBoxColumn
            // 
            this.datumPorudžbineDataGridViewTextBoxColumn.DataPropertyName = "DatumPorudžbine";
            this.datumPorudžbineDataGridViewTextBoxColumn.HeaderText = "DatumPorudžbine";
            this.datumPorudžbineDataGridViewTextBoxColumn.Name = "datumPorudžbineDataGridViewTextBoxColumn";
            // 
            // datumUgradnjeDataGridViewTextBoxColumn
            // 
            this.datumUgradnjeDataGridViewTextBoxColumn.DataPropertyName = "DatumUgradnje";
            this.datumUgradnjeDataGridViewTextBoxColumn.HeaderText = "DatumUgradnje";
            this.datumUgradnjeDataGridViewTextBoxColumn.Name = "datumUgradnjeDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // pregledKupacaBindingSource1
            // 
            this.pregledKupacaBindingSource1.DataMember = "Pregled_Kupaca";
            this.pregledKupacaBindingSource1.DataSource = this.kupciDataSet;
            // 
            // kupciDataSet
            // 
            this.kupciDataSet.DataSetName = "KupciDataSet";
            this.kupciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbPregled
            // 
            this.gbPregled.Controls.Add(this.dataGridView1);
            this.gbPregled.Location = new System.Drawing.Point(12, 150);
            this.gbPregled.Name = "gbPregled";
            this.gbPregled.Size = new System.Drawing.Size(776, 266);
            this.gbPregled.TabIndex = 3;
            this.gbPregled.TabStop = false;
            this.gbPregled.Text = "Kupci";
            // 
            // btnObrisi1
            // 
            this.btnObrisi1.Location = new System.Drawing.Point(12, 422);
            this.btnObrisi1.Name = "btnObrisi1";
            this.btnObrisi1.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi1.TabIndex = 8;
            this.btnObrisi1.Text = "Obrisi";
            this.btnObrisi1.UseVisualStyleBackColor = true;
            this.btnObrisi1.Click += new System.EventHandler(this.btnObrisi1_Click);
            // 
            // pregled_KupacaTableAdapter
            // 
            this.pregled_KupacaTableAdapter.ClearBeforeFill = true;
            // 
            // PregledKupaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnObrisi1);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.btnPocetna2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.gbPregled);
            this.Name = "PregledKupaca";
            this.Text = "PregledKupaca";
            this.Load += new System.EventHandler(this.PregledKupaca_Load);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataSet)).EndInit();
            this.gbPregled.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojTelefona1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Button btnPocetna2;
        private System.Windows.Forms.BindingSource pregledKupacaBindingSource;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPregled;
        private KupciDataSet kupciDataSet;
        private System.Windows.Forms.BindingSource pregledKupacaBindingSource1;
        private KupciDataSetTableAdapters.Pregled_KupacaTableAdapter pregled_KupacaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn širinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPorudžbineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUgradnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisi1;
    }
}