namespace SimicPlastBP
{
    partial class Prozori2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAlu = new System.Windows.Forms.RadioButton();
            this.rbPvc = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlu);
            this.groupBox1.Controls.Add(this.rbPvc);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 297);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materijal";
            // 
            // rbAlu
            // 
            this.rbAlu.AutoSize = true;
            this.rbAlu.Location = new System.Drawing.Point(485, 214);
            this.rbAlu.Name = "rbAlu";
            this.rbAlu.Size = new System.Drawing.Size(46, 17);
            this.rbAlu.TabIndex = 3;
            this.rbAlu.TabStop = true;
            this.rbAlu.Text = "ALU";
            this.rbAlu.UseVisualStyleBackColor = true;
            // 
            // rbPvc
            // 
            this.rbPvc.AutoSize = true;
            this.rbPvc.Location = new System.Drawing.Point(258, 212);
            this.rbPvc.Name = "rbPvc";
            this.rbPvc.Size = new System.Drawing.Size(46, 17);
            this.rbPvc.TabIndex = 2;
            this.rbPvc.TabStop = true;
            this.rbPvc.Text = "PVC";
            this.rbPvc.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SimicPlastBP.Properties.Resources.aluprofil;
            this.pictureBox4.Location = new System.Drawing.Point(445, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SimicPlastBP.Properties.Resources.pvcprofil;
            this.pictureBox3.Location = new System.Drawing.Point(217, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Izaberite materijal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Korak 2";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(551, 417);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 31;
            this.btnNazad.Text = "< Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click_1);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(632, 417);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 30;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click_1);
            // 
            // btnNapred
            // 
            this.btnNapred.Location = new System.Drawing.Point(713, 417);
            this.btnNapred.Name = "btnNapred";
            this.btnNapred.Size = new System.Drawing.Size(75, 23);
            this.btnNapred.TabIndex = 29;
            this.btnNapred.Text = "Napred >";
            this.btnNapred.UseVisualStyleBackColor = true;
            this.btnNapred.Click += new System.EventHandler(this.btnNapred_Click_1);
            // 
            // Prozori2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNapred);
            this.Name = "Prozori2";
            this.Text = "Prozori2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAlu;
        private System.Windows.Forms.RadioButton rbPvc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNapred;
    }
}