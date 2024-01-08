namespace GaziOdevApp
{
    partial class frmOgrBul
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
            this.Bul = new System.Windows.Forms.Button();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bul
            // 
            this.Bul.Location = new System.Drawing.Point(124, 132);
            this.Bul.Name = "Bul";
            this.Bul.Size = new System.Drawing.Size(75, 23);
            this.Bul.TabIndex = 3;
            this.Bul.Text = "Bul";
            this.Bul.UseVisualStyleBackColor = true;
            this.Bul.Click += new System.EventHandler(this.Bul_Click);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(113, 89);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(100, 22);
            this.txtOgrNo.TabIndex = 2;
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 259);
            this.Controls.Add(this.Bul);
            this.Controls.Add(this.txtOgrNo);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.Click += new System.EventHandler(this.Bul_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bul;
        private System.Windows.Forms.TextBox txtOgrNo;
    }
}