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
    public partial class frmOgrBul : Form
    {
        Form1 frm;
        public frmOgrBul(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void Bul_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(txtOgrNo.Text.Trim());
                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;

                    frm.btnOgrGuncelle.Enabled = true;
                    frm.btnOgrSil.Enabled = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
