using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Face
{
    public class Calisan
    {
        public static int CalisanEkle(Entity.Calisan cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", cl.Ad);
            cmd.Parameters.AddWithValue("@Soyad", cl.Soyad);
            cmd.Parameters.AddWithValue("@Email", cl.Email);
            cmd.Parameters.AddWithValue("@Telefon", cl.Telefon);
            cmd.Parameters.AddWithValue("@SubeID", cl.SubeID);
            cmd.Parameters.AddWithValue("@EvAdresi", cl.EvAdresi);
            cmd.Parameters.AddWithValue("@KullaniciAdi", cl.KullaniciAdi);
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisaTipID);
            cmd.Parameters.AddWithValue("@Yoneticimi", cl.Yoneticimi);
            cmd.Parameters.AddWithValue("@Sifre", cl.Sifre);
            return Util.Yurut(cmd);
        }
        public static int CalisanGuncelle(Entity.Calisan cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", cl.PersonelID);
            cmd.Parameters.AddWithValue("@Ad", cl.Ad);
            cmd.Parameters.AddWithValue("@Soyad", cl.Soyad);
            cmd.Parameters.AddWithValue("@Email", cl.Email);
            cmd.Parameters.AddWithValue("@Telefon", cl.Telefon);
            cmd.Parameters.AddWithValue("@SubeID", cl.SubeID);
            cmd.Parameters.AddWithValue("@EvAdresi", cl.EvAdresi);
            cmd.Parameters.AddWithValue("@KullaniciAdi", cl.KullaniciAdi);
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisaTipID);
            cmd.Parameters.AddWithValue("@Yoneticimi", cl.Yoneticimi);
            cmd.Parameters.AddWithValue("@Sifre", cl.Sifre);
            return Util.Yurut(cmd);
        }
        public static int CalisanSil(Entity.Calisan cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", cl.PersonelID);
            return Util.Yurut(cmd);
        }
        public static Entity.Calisan CalisanDetayGor(int personelID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", personelID);
            Entity.Calisan cl = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                cl = new Entity.Calisan();
                if (rdr.Read())
                {
                    cl.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    cl.Ad = Convert.ToString(rdr["Ad"]);
                    cl.Soyad = Convert.ToString(rdr["Soyad"]);
                    cl.Email = Convert.ToString(rdr["Email"]);
                    cl.Telefon = Convert.ToString(rdr["Telefon"]);
                    cl.SubeID = Convert.ToInt32(rdr["SubeID"]);
                    cl.EvAdresi = Convert.ToString(rdr["EvAdresi"]);
                    cl.KullaniciAdi = Convert.ToString(rdr["KullaniciAdi"]);
                    cl.CalisaTipID = Convert.ToInt32(rdr["CalisanTipID"]);
                    cl.Yoneticimi = Convert.ToBoolean(rdr["Yoneticimi"]);
                    cl.Sifre = Convert.ToString(rdr["Sifre"]);
                }
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
            }
            finally
            {
                cnn.Close();
            }
            return cl;
        }

        public static Entity.Calisan Login(Entity.Calisan calisan)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanGiris", cnn);

            cmd.CommandType = CommandType.StoredProcedure;

            string sifre = calisan.Sifre;
            cmd.Parameters.AddWithValue("@KullaniciAdi", calisan.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", sifre);

            Entity.Calisan donecekcalisan = null;

            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    donecekcalisan = new Entity.Calisan();
                    donecekcalisan.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    donecekcalisan.Yoneticimi = Convert.ToBoolean(rdr["Yoneticimi"]);
                    donecekcalisan.KullaniciAdi = Convert.ToString(rdr["KullaniciAdi"]);
                    donecekcalisan.SubeID = Convert.ToInt32(rdr["SubeID"]);
                    donecekcalisan.CalisaTipID = Convert.ToInt32(rdr["CalisanTipID"]);
                }
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return donecekcalisan;

        }
        public static void CalisanListesi(ListView Calisanlar)
        {
            Calisanlar.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Calisanlar.*, dbo.CalisanTipleri.CalisanTipAdi, dbo.Subeler.SubeAdi FROM  dbo.Calisanlar INNER JOIN  dbo.CalisanTipleri ON dbo.Calisanlar.CalisanTipID = dbo.CalisanTipleri.CalisanTipID INNER JOIN  dbo.Subeler ON dbo.Calisanlar.SubeID = dbo.Subeler.SubeID", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    Calisanlar.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Ad"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Soyad"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    if (rdr["Yoneticimi"].ToString() == "False")
                    {
                        Calisanlar.Items[i].SubItems.Add("Hayır");
                    }
                    else
                    {
                        Calisanlar.Items[i].SubItems.Add("Evet");
                    }
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }


        public static bool CalisanVarmi(string calisanadi, string calisansoyadi)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Calisanlar where Ad=@Ad and  Soyad=@Soyad", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sonuc = true;
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return sonuc;
        }



        public static int CalisanSayisi()
        {
            int cs = 0;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select Count(PersonelID) as CalisanSayisi from Calisanlar", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cs = Convert.ToInt32(rdr["CalisanSayisi"]);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return cs;
        }

        public static void AdaGoreCalisanGetir(ListView lsvcalisan, string aranacakcalisan)
        {
            lsvcalisan.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Calisanlar.*,CalisanTipleri.CalisanTipAdi,Subeler.SubeAdi from Calisanlar inner join Subeler on Calisanlar.SubeID = Subeler.SubeID inner join CalisanTipleri on Calisanlar.CalisanTipID=CalisanTipleri.CalisanTipID where Calisanlar.Ad Like @CalisanAd+'%'", cnn);
            cmd.Parameters.AddWithValue("@CalisanAd", aranacakcalisan);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lsvcalisan.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Ad"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Soyad"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["Yoneticimi"]));
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipID"]).ToString());
                    lsvcalisan.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    i++;

                }
                rdr.Close();

            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static void SubeAdinaGoreCalisanGetir(ListView Calisanlar, string SubeAdi)
        {
            Calisanlar.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Calisanlar.*,CalisanTipleri.CalisanTipAdi,Subeler.SubeAdi from Calisanlar inner join Subeler on Calisanlar.SubeID = Subeler.SubeID inner join CalisanTipleri on Calisanlar.CalisanTipID=CalisanTipleri.CalisanTipID where Subeler.SubeAdi Like @SubeAdi+'%'", cnn);
            cmd.Parameters.AddWithValue("@SubeAdi", SubeAdi);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    Calisanlar.Items.Add(Convert.ToInt32(rdr["PersonelID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Ad"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Soyad"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Telefon"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Email"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["SubeID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["EvAdresi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["KullaniciAdi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Sifre"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["Yoneticimi"]));
                    Calisanlar.Items[i].SubItems.Add(Convert.ToInt32(rdr["CalisanTipID"]).ToString());
                    Calisanlar.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    i++;

                }
                rdr.Close();
                cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CalisanAdiGetir(ComboBox cmbMasrafYapanPersoneller)
        {
            cmbMasrafYapanPersoneller.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select PersonelID,Ad,Soyad from Calisanlar", cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Calisan mt = new Entity.Calisan();
                    mt.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    mt.Ad = Convert.ToString(rdr["Ad"]);
                    mt.Soyad = Convert.ToString(rdr["Soyad"]);
                    cmbMasrafYapanPersoneller.Items.Add(mt);
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
           
        }
    }
}
