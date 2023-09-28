namespace SimicPlastBP
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.btnVrata = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnKomarnici = new System.Windows.Forms.Button();
            this.btnRoletne = new System.Windows.Forms.Button();
            this.btnProzori = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVrata
            // 
            this.btnVrata.Image = global::SimicPlastBP.Properties.Resources.vrata;
            this.btnVrata.Location = new System.Drawing.Point(579, 169);
            this.btnVrata.Name = "btnVrata";
            this.btnVrata.Size = new System.Drawing.Size(78, 97);
            this.btnVrata.TabIndex = 9;
            this.btnVrata.Text = "Vrata";
            this.btnVrata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVrata.UseVisualStyleBackColor = true;
            this.btnVrata.Click += new System.EventHandler(this.btnVrata_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Image = global::SimicPlastBP.Properties.Resources.icons8_search_contacts_50;
            this.btnPregled.Location = new System.Drawing.Point(434, 303);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(75, 97);
            this.btnPregled.TabIndex = 14;
            this.btnPregled.Text = "Pregled kupaca";
            this.btnPregled.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Image = global::SimicPlastBP.Properties.Resources.icons8_add_user_male_50;
            this.btnUnos.Location = new System.Drawing.Point(288, 303);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 97);
            this.btnUnos.TabIndex = 13;
            this.btnUnos.Text = "Unos kupca";
            this.btnUnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnKomarnici
            // 
            this.btnKomarnici.Image = global::SimicPlastBP.Properties.Resources.komarnik;
            this.btnKomarnici.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKomarnici.Location = new System.Drawing.Point(434, 169);
            this.btnKomarnici.Name = "btnKomarnici";
            this.btnKomarnici.Size = new System.Drawing.Size(75, 97);
            this.btnKomarnici.TabIndex = 12;
            this.btnKomarnici.Text = "Komarnici";
            this.btnKomarnici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKomarnici.UseVisualStyleBackColor = true;
            this.btnKomarnici.Click += new System.EventHandler(this.btnKomarnici_Click);
            // 
            // btnRoletne
            // 
            this.btnRoletne.Image = global::SimicPlastBP.Properties.Resources.roletna;
            this.btnRoletne.Location = new System.Drawing.Point(288, 169);
            this.btnRoletne.Name = "btnRoletne";
            this.btnRoletne.Size = new System.Drawing.Size(75, 97);
            this.btnRoletne.TabIndex = 11;
            this.btnRoletne.Text = "Roletne";
            this.btnRoletne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoletne.UseVisualStyleBackColor = true;
            this.btnRoletne.Click += new System.EventHandler(this.btnRoletne_Click_1);
            // 
            // btnProzori
            // 
            this.btnProzori.Image = global::SimicPlastBP.Properties.Resources.prozor;
            this.btnProzori.Location = new System.Drawing.Point(143, 169);
            this.btnProzori.Name = "btnProzori";
            this.btnProzori.Size = new System.Drawing.Size(75, 97);
            this.btnProzori.TabIndex = 10;
            this.btnProzori.Text = "Prozori";
            this.btnProzori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProzori.UseVisualStyleBackColor = true;
            this.btnProzori.Click += new System.EventHandler(this.btnProzori_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnKomarnici);
            this.Controls.Add(this.btnRoletne);
            this.Controls.Add(this.btnProzori);
            this.Controls.Add(this.btnVrata);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pocetna";
            this.Text = "Pocetrna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnKomarnici;
        private System.Windows.Forms.Button btnRoletne;
        private System.Windows.Forms.Button btnProzori;
        private System.Windows.Forms.Button btnVrata;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}