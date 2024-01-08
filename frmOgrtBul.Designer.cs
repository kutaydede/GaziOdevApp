namespace GaziOdevApp
{
    partial class frmOgrtBul
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
            this.OgrtBul = new System.Windows.Forms.Button();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OgrtBul
            // 
            this.OgrtBul.Location = new System.Drawing.Point(118, 128);
            this.OgrtBul.Name = "OgrtBul";
            this.OgrtBul.Size = new System.Drawing.Size(75, 23);
            this.OgrtBul.TabIndex = 3;
            this.OgrtBul.Text = "Bul";
            this.OgrtBul.UseVisualStyleBackColor = true;
            this.OgrtBul.Click += new System.EventHandler(this.OgrtBul_Click);
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(107, 85);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(100, 22);
            this.txtOgrtTc.TabIndex = 2;
            // 
            // frmOgrtBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 237);
            this.Controls.Add(this.OgrtBul);
            this.Controls.Add(this.txtOgrtTc);
            this.Name = "frmOgrtBul";
            this.Text = "frmOgrtBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OgrtBul;
        private System.Windows.Forms.TextBox txtOgrtTc;
    }
}