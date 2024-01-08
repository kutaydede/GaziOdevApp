namespace GaziOdevApp
{
    partial class Form1
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
            this.btnOgrtBul = new System.Windows.Forms.Button();
            this.btnOgrtSil = new System.Windows.Forms.Button();
            this.btnOgrtGuncelle = new System.Windows.Forms.Button();
            this.btnOgrBul = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.btnOgrGuncelle = new System.Windows.Forms.Button();
            this.btnOgrtKaydet = new System.Windows.Forms.Button();
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.lblOgrtAd = new System.Windows.Forms.Label();
            this.lblOgrtSoyad = new System.Windows.Forms.Label();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.lblOgrtTc = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.grpOgretmen.SuspendLayout();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOgrtBul
            // 
            this.btnOgrtBul.Location = new System.Drawing.Point(830, 212);
            this.btnOgrtBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrtBul.Name = "btnOgrtBul";
            this.btnOgrtBul.Size = new System.Drawing.Size(133, 28);
            this.btnOgrtBul.TabIndex = 61;
            this.btnOgrtBul.Text = "Bul";
            this.btnOgrtBul.UseVisualStyleBackColor = true;
            this.btnOgrtBul.Click += new System.EventHandler(this.btnOgrtBul_Click);
            // 
            // btnOgrtSil
            // 
            this.btnOgrtSil.Enabled = false;
            this.btnOgrtSil.Location = new System.Drawing.Point(830, 154);
            this.btnOgrtSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrtSil.Name = "btnOgrtSil";
            this.btnOgrtSil.Size = new System.Drawing.Size(133, 28);
            this.btnOgrtSil.TabIndex = 60;
            this.btnOgrtSil.Text = "Sil";
            this.btnOgrtSil.UseVisualStyleBackColor = true;
            this.btnOgrtSil.Click += new System.EventHandler(this.btnOgrtSil_Click);
            // 
            // btnOgrtGuncelle
            // 
            this.btnOgrtGuncelle.Enabled = false;
            this.btnOgrtGuncelle.Location = new System.Drawing.Point(830, 93);
            this.btnOgrtGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrtGuncelle.Name = "btnOgrtGuncelle";
            this.btnOgrtGuncelle.Size = new System.Drawing.Size(133, 28);
            this.btnOgrtGuncelle.TabIndex = 59;
            this.btnOgrtGuncelle.Text = "Guncelle";
            this.btnOgrtGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrtGuncelle.Click += new System.EventHandler(this.btnOgrtGuncelle_Click);
            // 
            // btnOgrBul
            // 
            this.btnOgrBul.Location = new System.Drawing.Point(361, 212);
            this.btnOgrBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrBul.Name = "btnOgrBul";
            this.btnOgrBul.Size = new System.Drawing.Size(133, 28);
            this.btnOgrBul.TabIndex = 58;
            this.btnOgrBul.Text = "Bul";
            this.btnOgrBul.UseVisualStyleBackColor = true;
            this.btnOgrBul.Click += new System.EventHandler(this.btnOgrBul_Click);
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.Enabled = false;
            this.btnOgrSil.Location = new System.Drawing.Point(361, 154);
            this.btnOgrSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(133, 28);
            this.btnOgrSil.TabIndex = 57;
            this.btnOgrSil.Text = "Sil";
            this.btnOgrSil.UseVisualStyleBackColor = true;
            this.btnOgrSil.Click += new System.EventHandler(this.btnOgrSil_Click);
            // 
            // btnOgrGuncelle
            // 
            this.btnOgrGuncelle.Enabled = false;
            this.btnOgrGuncelle.Location = new System.Drawing.Point(361, 93);
            this.btnOgrGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrGuncelle.Name = "btnOgrGuncelle";
            this.btnOgrGuncelle.Size = new System.Drawing.Size(133, 28);
            this.btnOgrGuncelle.TabIndex = 56;
            this.btnOgrGuncelle.Text = "Güncelle";
            this.btnOgrGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrGuncelle.Click += new System.EventHandler(this.btnOgrGuncelle_Click);
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.Location = new System.Drawing.Point(830, 28);
            this.btnOgrtKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnOgrtKaydet.TabIndex = 55;
            this.btnOgrtKaydet.Text = "Kaydet";
            this.btnOgrtKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txtOgrtTc);
            this.grpOgretmen.Controls.Add(this.lblOgrtAd);
            this.grpOgretmen.Controls.Add(this.lblOgrtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtAd);
            this.grpOgretmen.Controls.Add(this.lblOgrtTc);
            this.grpOgretmen.Location = new System.Drawing.Point(531, 28);
            this.grpOgretmen.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Size = new System.Drawing.Size(281, 187);
            this.grpOgretmen.TabIndex = 54;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(112, 37);
            this.txtOgrtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtTc.TabIndex = 3;
            // 
            // lblOgrtAd
            // 
            this.lblOgrtAd.AutoSize = true;
            this.lblOgrtAd.Location = new System.Drawing.Point(39, 90);
            this.lblOgrtAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtAd.Name = "lblOgrtAd";
            this.lblOgrtAd.Size = new System.Drawing.Size(24, 16);
            this.lblOgrtAd.TabIndex = 4;
            this.lblOgrtAd.Text = "Ad";
            // 
            // lblOgrtSoyad
            // 
            this.lblOgrtSoyad.AutoSize = true;
            this.lblOgrtSoyad.Location = new System.Drawing.Point(39, 144);
            this.lblOgrtSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtSoyad.Name = "lblOgrtSoyad";
            this.lblOgrtSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblOgrtSoyad.TabIndex = 5;
            this.lblOgrtSoyad.Text = "Soyad";
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(112, 138);
            this.txtOgrtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtSoyad.TabIndex = 2;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(111, 81);
            this.txtOgrtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtAd.TabIndex = 1;
            // 
            // lblOgrtTc
            // 
            this.lblOgrtTc.AutoSize = true;
            this.lblOgrtTc.Location = new System.Drawing.Point(39, 46);
            this.lblOgrtTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtTc.Name = "lblOgrtTc";
            this.lblOgrtTc.Size = new System.Drawing.Size(23, 16);
            this.lblOgrtTc.TabIndex = 6;
            this.lblOgrtTc.Text = "Tc";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(361, 28);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnKaydet.TabIndex = 53;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(37, 28);
            this.grpOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Size = new System.Drawing.Size(281, 187);
            this.grpOgrenci.TabIndex = 52;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(111, 138);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(132, 22);
            this.txtNumara.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 46);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(39, 90);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(39, 138);
            this.lblNumara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "Numara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(111, 81);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 37);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 267);
            this.Controls.Add(this.btnOgrtBul);
            this.Controls.Add(this.btnOgrtSil);
            this.Controls.Add(this.btnOgrtGuncelle);
            this.Controls.Add(this.btnOgrBul);
            this.Controls.Add(this.btnOgrSil);
            this.Controls.Add(this.btnOgrGuncelle);
            this.Controls.Add(this.btnOgrtKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnOgrtBul;
        public System.Windows.Forms.Button btnOgrtSil;
        public System.Windows.Forms.Button btnOgrtGuncelle;
        public System.Windows.Forms.Button btnOgrBul;
        public System.Windows.Forms.Button btnOgrSil;
        public System.Windows.Forms.Button btnOgrGuncelle;
        public System.Windows.Forms.Button btnOgrtKaydet;
        public System.Windows.Forms.GroupBox grpOgretmen;
        public System.Windows.Forms.TextBox txtOgrtTc;
        public System.Windows.Forms.Label lblOgrtAd;
        public System.Windows.Forms.Label lblOgrtSoyad;
        public System.Windows.Forms.TextBox txtOgrtSoyad;
        public System.Windows.Forms.TextBox txtOgrtAd;
        public System.Windows.Forms.Label lblOgrtTc;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.GroupBox grpOgrenci;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.Label lblNumara;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
    }
}

