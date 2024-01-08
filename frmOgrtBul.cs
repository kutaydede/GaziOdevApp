using GaziApp.MODEL;
using OkulAppBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaziOdevApp
{
    public partial class frmOgrtBul : Form
    {
        Form1 frm;
        public frmOgrtBul(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void OgrtBul_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                Ogretmen ogrt = obl.OgretmenBul(txtOgrtTc.Text.Trim());
                if (ogrt != null)
                {
                    frm.txtOgrtTc.Text = ogrt.Tc;
                    frm.txtOgrtAd.Text = ogrt.Ad;
                    frm.txtOgrtSoyad.Text = ogrt.Soyad;
                    frm.Ogretmenid = ogrt.OgretmenId;

                    frm.btnOgrtGuncelle.Enabled = true;
                    frm.btnOgrtSil.Enabled = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Öğretmen Bulunamadı");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
