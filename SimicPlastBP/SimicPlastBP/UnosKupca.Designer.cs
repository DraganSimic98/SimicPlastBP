namespace SimicPlastBP
{
    partial class UnosKupca
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
            this.btnPocetna1 = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.dtpUgradnja = new System.Windows.Forms.DateTimePicker();
            this.dtpPorudzbina = new System.Windows.Forms.DateTimePicker();
            this.gbUnos = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVisina1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSirina = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbMaterijal = new System.Windows.Forms.ComboBox();
            this.cbProizvod = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kupciDataSet = new SimicPlastBP.KupciDataSet();
            this.pregledKupacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_KupacaTableAdapter = new SimicPlastBP.KupciDataSetTableAdapters.Pregled_KupacaTableAdapter();
            this.btnPretraga1 = new System.Windows.Forms.Button();
            this.gbUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPocetna1
            // 
            this.btnPocetna1.Location = new System.Drawing.Point(95, 402);
            this.btnPocetna1.Name = "btnPocetna1";
            this.btnPocetna1.Size = new System.Drawing.Size(75, 23);
            this.btnPocetna1.TabIndex = 15;
            this.btnPocetna1.Text = "Pocetna";
            this.btnPocetna1.UseVisualStyleBackColor = true;
            this.btnPocetna1.Click += new System.EventHandler(this.btnPocetna1_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(550, 402);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 14;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // dtpUgradnja
            // 
            this.dtpUgradnja.Location = new System.Drawing.Point(404, 113);
            this.dtpUgradnja.Name = "dtpUgradnja";
            this.dtpUgradnja.Size = new System.Drawing.Size(200, 20);
            this.dtpUgradnja.TabIndex = 19;
            // 
            // dtpPorudzbina
            // 
            this.dtpPorudzbina.Location = new System.Drawing.Point(404, 59);
            this.dtpPorudzbina.Name = "dtpPorudzbina";
            this.dtpPorudzbina.Size = new System.Drawing.Size(200, 20);
            this.dtpPorudzbina.TabIndex = 18;
            // 
            // gbUnos
            // 
            this.gbUnos.Controls.Add(this.dtpUgradnja);
            this.gbUnos.Controls.Add(this.dtpPorudzbina);
            this.gbUnos.Controls.Add(this.txtCena);
            this.gbUnos.Controls.Add(this.label12);
            this.gbUnos.Controls.Add(this.label11);
            this.gbUnos.Controls.Add(this.txtVisina1);
            this.gbUnos.Controls.Add(this.label9);
            this.gbUnos.Controls.Add(this.txbSirina);
            this.gbUnos.Controls.Add(this.cbTip);
            this.gbUnos.Controls.Add(this.cbMaterijal);
            this.gbUnos.Controls.Add(this.cbProizvod);
            this.gbUnos.Controls.Add(this.txtTel);
            this.gbUnos.Controls.Add(this.label10);
            this.gbUnos.Controls.Add(this.txtAdresa);
            this.gbUnos.Controls.Add(this.txtPrezime);
            this.gbUnos.Controls.Add(this.label8);
            this.gbUnos.Controls.Add(this.txtIme);
            this.gbUnos.Controls.Add(this.label7);
            this.gbUnos.Controls.Add(this.label1);
            this.gbUnos.Controls.Add(this.label6);
            this.gbUnos.Controls.Add(this.label2);
            this.gbUnos.Controls.Add(this.label5);
            this.gbUnos.Controls.Add(this.label3);
            this.gbUnos.Controls.Add(this.label4);
            this.gbUnos.Location = new System.Drawing.Point(95, 26);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(611, 370);
            this.gbUnos.TabIndex = 13;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Informacije o kupcu";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(404, 171);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cena:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Datum ugradnje:";
            // 
            // txtVisina1
            // 
            this.txtVisina1.Location = new System.Drawing.Point(205, 171);
            this.txtVisina1.Name = "txtVisina1";
            this.txtVisina1.Size = new System.Drawing.Size(121, 20);
            this.txtVisina1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Datum porudžbine:";
            // 
            // txbSirina
            // 
            this.txbSirina.Location = new System.Drawing.Point(205, 113);
            this.txbSirina.Name = "txbSirina";
            this.txbSirina.Size = new System.Drawing.Size(121, 20);
            this.txbSirina.TabIndex = 14;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Jednokrilni",
            "Dvokrilni"});
            this.cbTip.Location = new System.Drawing.Point(205, 292);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 11;
            // 
            // cbMaterijal
            // 
            this.cbMaterijal.FormattingEnabled = true;
            this.cbMaterijal.Items.AddRange(new object[] {
            "PVC",
            "ALU"});
            this.cbMaterijal.Location = new System.Drawing.Point(205, 226);
            this.cbMaterijal.Name = "cbMaterijal";
            this.cbMaterijal.Size = new System.Drawing.Size(121, 21);
            this.cbMaterijal.TabIndex = 12;
            // 
            // cbProizvod
            // 
            this.cbProizvod.FormattingEnabled = true;
            this.cbProizvod.Items.AddRange(new object[] {
            "Prozor"});
            this.cbProizvod.Location = new System.Drawing.Point(205, 58);
            this.cbProizvod.Name = "cbProizvod";
            this.cbProizvod.Size = new System.Drawing.Size(121, 21);
            this.cbProizvod.TabIndex = 13;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(9, 226);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tip:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(9, 171);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(6, 113);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Materijal:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(7, 58);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Visina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Širina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proizvod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj telefona:";
            // 
            // kupciDataSet
            // 
            this.kupciDataSet.DataSetName = "KupciDataSet";
            this.kupciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledKupacaBindingSource
            // 
            this.pregledKupacaBindingSource.DataMember = "Pregled_Kupaca";
            this.pregledKupacaBindingSource.DataSource = this.kupciDataSet;
            // 
            // pregled_KupacaTableAdapter
            // 
            this.pregled_KupacaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPretraga1
            // 
            this.btnPretraga1.Location = new System.Drawing.Point(631, 402);
            this.btnPretraga1.Name = "btnPretraga1";
            this.btnPretraga1.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga1.TabIndex = 16;
            this.btnPretraga1.Text = "Pretraga";
            this.btnPretraga1.UseVisualStyleBackColor = true;
            this.btnPretraga1.Click += new System.EventHandler(this.btnPretraga1_Click);
            // 
            // UnosKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretraga1);
            this.Controls.Add(this.btnPocetna1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.gbUnos);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pregledKupacaBindingSource, "Id", true));
            this.Name = "UnosKupca";
            this.Text = "UnosKupca";
            this.Load += new System.EventHandler(this.UnosKupca_Load);
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledKupacaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPocetna1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.DateTimePicker dtpUgradnja;
        private System.Windows.Forms.DateTimePicker dtpPorudzbina;
        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVisina1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSirina;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbMaterijal;
        private System.Windows.Forms.ComboBox cbProizvod;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private KupciDataSet kupciDataSet;
        private System.Windows.Forms.BindingSource pregledKupacaBindingSource;
        private KupciDataSetTableAdapters.Pregled_KupacaTableAdapter pregled_KupacaTableAdapter;
        private System.Windows.Forms.Button btnPretraga1;
    }
}