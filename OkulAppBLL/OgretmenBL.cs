using DAL;
using GaziApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulAppBLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Tc",ogrt.Tc),
                                  new SqlParameter("@Ad",ogrt.Ad),
                                  new SqlParameter("@Soyad",ogrt.Soyad),

                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogretmenler (Tc,Ad,Soyad) values (@Tc,@Ad,@Soyad)", p) > 0;
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

            }
        }
        public bool OgretmenGuncelle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ogretmenid",ogrt.OgretmenId),
                             new SqlParameter("@Tc",ogrt.Tc),
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad)


                         };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Update Ogretmenler set Ad=@Ad,Soyad=@Soyad,Tc=@Tc where OgretmenId=@Ogretmenid", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool OgretmenSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ogretmenid", id) };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from Ogretmenler where OgretmenId=@Ogretmenid", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Ogretmen OgretmenBul(string Tc)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tc", Tc) };
                var hlp = new Helper();
                var dr = hlp.ExecuteReader("Select OgretmenId,Tc,Ad,Soyad from Ogretmenler where Tc=@Tc", p);
                Ogretmen ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogretmen();
                    ogrt.OgretmenId = Convert.ToInt32(dr["OgretmenId"]);
                    ogrt.Tc = dr["Tc"].ToString();
                    ogrt.Ad = dr["Ad"].ToString();
                    ogrt.Soyad = dr["Soyad"].ToString();

                }
                dr.Close();
                return ogrt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

