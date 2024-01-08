using GaziApp.MODEL;
using OkulAppBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaziOdevApp
{
    public partial class Form1 : Form
    {

        public int Ogrenciid { get; set; }
        public int Ogretmenid { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        //Dispose
        //Garbage Collector
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //var ogrenci = new Ogrenci();
                //ogrenci.Ad = txtAd.Text.Trim();
                //ogrenci.Soyad = txtSoyad.Text.Trim();
                //ogrenci.Numara = txtNumara.Text.Trim();

                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtNumara.Text))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
                    return;
                }
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
            OgrTxtClear();
            OgrBtnEnabled();
        }
        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Numara = txtNumara.Text.Trim(),
                    Ogrenciid = Ogrenciid
                }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
                OgrTxtClear();
                OgrBtnEnabled();
                MessageBox.Show(obl.instanceCount()); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciSil(Ogrenciid) ? "Silme Başarılı" : "Başarısız!");
                OgrTxtClear();
                OgrBtnEnabled();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOgrBul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOgrBul(this);
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOgrtAd.Text) || string.IsNullOrWhiteSpace(txtOgrtSoyad.Text) || string.IsNullOrWhiteSpace(txtOgrtTc.Text))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
                    return;
                }
                var ogrtbl = new OgretmenBL();
                bool sonuc = ogrtbl.OgretmenEkle(new Ogretmen { Tc = txtOgrtTc.Text.Trim(), Ad = txtOgrtAd.Text.Trim(), Soyad = txtOgrtSoyad.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
            OgrtTxtClear();
            OgrtBtnEnabled();
        }

        private void btnOgrtGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtbl = new OgretmenBL();
                MessageBox.Show(ogrtbl.OgretmenGuncelle(new Ogretmen
                {
                    Ad = txtOgrtAd.Text.Trim(),
                    Soyad = txtOgrtSoyad.Text.Trim(),
                    Tc = txtOgrtTc.Text.Trim(),
                    OgretmenId = Ogretmenid
                }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
                OgrtTxtClear();
                OgrtBtnEnabled();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOgrtSil_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrtBul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOgrtBul(this);
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void OgrTxtClear()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }
        private void OgrBtnEnabled()
        {

            btnOgrSil.Enabled = false;
            btnOgrGuncelle.Enabled = false;

        }
        private void OgrtTxtClear()
        {
            txtOgrtAd.Clear();
            txtOgrtSoyad.Clear();
            txtOgrtTc.Clear();
        }
        private void OgrtBtnEnabled()
        {
            btnOgrtGuncelle.Enabled = false;
            btnOgrtSil.Enabled = false;
        }

    }
    interface ITransfer
    {
        int EFT(string aliciiban, string gondereniban, double tutar);
        int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih);
    }

    class TransferIslemleri : ITransfer
    {
        public int EFT(string aliciiban, string gondereniban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih)
        {
            throw new NotImplementedException();
        }
    }
}

//n Katmanlı Mimari

