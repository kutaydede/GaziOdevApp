using DAL;
using GaziApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulAppBLL
{
    public class OgrenciBL
    {

        //öğretmen tablosu için => tc kimlik ad soyad
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogr.Ad),
                                  new SqlParameter("@Soyad",ogr.Soyad),
                                  new SqlParameter("@Numara",ogr.Numara)
                            };

                var hlp = Helper.helper;
                return hlp.ExecuteNonQuery("Insert into Ogrenciler (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }
        public Ogrenci OgrenciBul(string numara)
        {
            var hlp = Helper.helper;
            try
            {
                
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from Ogrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                    ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                }
                dr.Close();
                return ogr;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                hlp.Dispose();
            }
        }

        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", id) };
                Helper hlp = Helper.helper;
                return hlp.ExecuteNonQuery("Delete from Ogrenciler where OgrenciId=@Id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@OgrenciId",ogr.Ogrenciid)};

                Helper hlp = Helper.helper;
                return hlp.ExecuteNonQuery("Update Ogrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string instanceCount()
        {
            var hlp = Helper.helper;
            return " Oluşturulan nesne sayısı :" + hlp.GetInstanceCount();
        }

    }
}
