using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Face
{
    public class Musteri
    {
        public static int MusteriEkle(Entity.Musteri ms)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MusteriEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", ms.Ad);
            cmd.Parameters.AddWithValue("@Soyad", ms.SoyAd);
            cmd.Parameters.AddWithValue("@Email", ms.Email);
            cmd.Parameters.AddWithValue("@Telefon", ms.Telefon);
            cmd.Parameters.AddWithValue("@Cinsiyet", ms.Cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", ms.DogumTarihi);
            cmd.Parameters.AddWithValue("@SehirID", ms.SehirID);
            cmd.Parameters.AddWithValue("@Adres", ms.Adres);
            cmd.Parameters.AddWithValue("@KartNumarasi", ms.KartNumarasi);
            cmd.Parameters.AddWithValue("@KartTeslimDurumu", ms.KartTeslimDurumu);
            cmd.Parameters.AddWithValue("@MevcutPara", ms.MevcutPara);
            return Util.Yurut(cmd);
        }
        public static int MusteriGuncelle(Entity.Musteri ms)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MusteriGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriID", ms.MusteriID);
            cmd.Parameters.AddWithValue("@Ad", ms.Ad);
            cmd.Parameters.AddWithValue("@Soyad", ms.SoyAd);
            cmd.Parameters.AddWithValue("@Email", ms.Email);
            cmd.Parameters.AddWithValue("@Telefon", ms.Telefon);
            cmd.Parameters.AddWithValue("@Cinsiyet", ms.Cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", ms.DogumTarihi);
            cmd.Parameters.AddWithValue("@SehirID", ms.SehirID);
            cmd.Parameters.AddWithValue("@Adres", ms.Adres);
            cmd.Parameters.AddWithValue("@KartNumarasi", ms.KartNumarasi);
            cmd.Parameters.AddWithValue("@KartTeslimDurumu", ms.KartTeslimDurumu);
            cmd.Parameters.AddWithValue("@MevcutPara", ms.MevcutPara);
            return Util.Yurut(cmd);
        }
        public static int MusteriSil(Entity.Musteri ms)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MusteriSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriID", ms.MusteriID);
            return Util.Yurut(cmd);
        }
        public static Entity.Musteri MusteriDetayGor(int musteriID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MusteriDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriID", musteriID);
            Entity.Musteri ms = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                ms = new Entity.Musteri();
                if (rdr.Read())
                {
                    ms.MusteriID = Convert.ToInt32(rdr["MsuteriID"]);
                    ms.Ad = Convert.ToString(rdr["Ad"]);
                    ms.SoyAd = Convert.ToString(rdr["Soyad"]);
                    ms.Email = Convert.ToString(rdr["Email"]);
                    ms.Telefon = Convert.ToString(rdr["Telefon"]);
                    ms.Cinsiyet = Convert.ToBoolean(rdr["Cinsiyet"]);
                    ms.DogumTarihi = Convert.ToDateTime(rdr["DogumTarihi"]);
                    ms.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    ms.Adres = Convert.ToString(rdr["Adres"]);
                    ms.KartNumarasi = Convert.ToString(rdr["KartNumarasi"]);
                    ms.KartTeslimDurumu = Convert.ToBoolean(rdr["KartTeslimDurumu"]);
                    ms.MevcutPara = Convert.ToDecimal(rdr["MevcutPara"]);
                }
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
            }
            finally
            {
                cnn.Close();
            } return ms;
        }

        public static int MüsteriSayisi()
        {
            int os = 0;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select count(MusteriID)as MusteriSayisi from Musteriler", cnn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                os = Convert.ToInt32(rdr["MusteriSayisi"]);
            }
            return os;
        }

        public static void MüsterileriGetir(System.Windows.Forms.ListView Müsteriler)
        {
            Müsteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Musteriler.*,Sehirler.SehirAdi from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID", cnn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();

            }

            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                Müsteriler.Items.Add(Convert.ToInt32(rdr["MusteriID"]).ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["Ad"].ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["SoyAd"].ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["Email"].ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["Telefon"].ToString());
                if (rdr["Cinsiyet"].ToString() == "False")
                {
                    Müsteriler.Items[i].SubItems.Add("Bay");
                }
                else
                {
                    Müsteriler.Items[i].SubItems.Add("Bayan");
                }
                Müsteriler.Items[i].SubItems.Add(Convert.ToDateTime(rdr["DogumTarihi"]).ToShortDateString());
                Müsteriler.Items[i].SubItems.Add(Convert.ToInt32(rdr["SehirID"]).ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["SehirAdi"].ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["Adres"].ToString());
                Müsteriler.Items[i].SubItems.Add(rdr["KartNumarasi"].ToString());
                if (rdr["KartTeslimDurumu"].ToString() == "True")
                {
                    Müsteriler.Items[i].SubItems.Add("Teslim Edildi");

                }
                else
                {
                    Müsteriler.Items[i].SubItems.Add("Teslim Edilmedi");
                }
                Müsteriler.Items[i].SubItems.Add(Convert.ToDecimal(rdr["MevcutPara"]).ToString());
                i++;
            }
        }

        public static bool MusteriVarMi(string isim, string soyad)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Ad,Soyad from Musteriler where Ad=@Ad and Soyad =@Soyad", cnn);
            cmd.Parameters.AddWithValue("@Ad", isim);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();

            }
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                sonuc = true;
            }


            return sonuc;
        }

        public static bool KartNumarasiVarMi(string KartNumarasi)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select KartNumarasi from Musteriler where KartNumarasi=@KartNumarasi", cnn);
            cmd.Parameters.AddWithValue("@KartNumarasi", KartNumarasi);

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
            cnn.Close();
            return sonuc;
        }

        public static void AdaGoreMusteriAra(ListView Musteriler, string Ad)
        {
            Musteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Musteriler.*,Sehirler.SehirAdi from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID where Ad Like @Ad+'%'", cnn);
            cmd.Parameters.AddWithValue("@Ad", Ad);
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
                    Musteriler.Items.Add(Convert.ToInt32(rdr["MusteriID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SoyAd"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Email"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Telefon"].ToString());
                    if (rdr["Cinsiyet"].ToString() == "False")
                    {
                        Musteriler.Items[i].SubItems.Add("Bay");
                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Bayan");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDateTime(rdr["DogumTarihi"]).ToShortDateString());
                    Musteriler.Items[i].SubItems.Add(Convert.ToInt32(rdr["SehirID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SehirAdi"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["KartNumarasi"].ToString());
                    if (rdr["KartTeslimDurumu"].ToString() == "True")
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edildi");

                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edilmedi");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDecimal(rdr["MevcutPara"]).ToString());
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

        public static void EmaileGoreMusteriAra(ListView Musteriler, string Email)
        {
            Musteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Musteriler.*,Sehirler.SehirAdi from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID where Email Like @Email+'%'", cnn);
            cmd.Parameters.AddWithValue("@Email", Email);
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
                    Musteriler.Items.Add(Convert.ToInt32(rdr["MusteriID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SoyAd"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Email"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Telefon"].ToString());
                    if (rdr["Cinsiyet"].ToString() == "False")
                    {
                        Musteriler.Items[i].SubItems.Add("Bay");
                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Bayan");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDateTime(rdr["DogumTarihi"]).ToShortDateString());
                    Musteriler.Items[i].SubItems.Add(Convert.ToInt32(rdr["SehirID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SehirAdi"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["KartNumarasi"].ToString());
                    if (rdr["KartTeslimDurumu"].ToString() == "True")
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edildi");

                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edilmedi");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDecimal(rdr["MevcutPara"]).ToString());
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

        public static void TelefonaGoreMusteriAra(ListView Musteriler, string Telefon)
        {
            Musteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Musteriler.*,Sehirler.SehirAdi from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID where Telefon Like @Telefon+'%'", cnn);
            cmd.Parameters.AddWithValue("@Telefon", Telefon);
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
                    Musteriler.Items.Add(Convert.ToInt32(rdr["MusteriID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SoyAd"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Email"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Telefon"].ToString());
                    if (rdr["Cinsiyet"].ToString() == "False")
                    {
                        Musteriler.Items[i].SubItems.Add("Bay");
                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Bayan");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDateTime(rdr["DogumTarihi"]).ToShortDateString());
                    Musteriler.Items[i].SubItems.Add(Convert.ToInt32(rdr["SehirID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SehirAdi"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["KartNumarasi"].ToString());
                    if (rdr["KartTeslimDurumu"].ToString() == "True")
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edildi");

                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edilmedi");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDecimal(rdr["MevcutPara"]).ToString());
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

        public static void KartNumarasınaGoreMusteriAra(ListView Musteriler, string KartNumarasi)
        {
            Musteriler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Musteriler.*,Sehirler.SehirAdi from Musteriler inner join Sehirler on Musteriler.SehirID=Sehirler.SehirID where KartNumarasi Like @KartNumarasi+'%'", cnn);
            cmd.Parameters.AddWithValue("@KartNumarasi", KartNumarasi);
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
                    Musteriler.Items.Add(Convert.ToInt32(rdr["MusteriID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SoyAd"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Email"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Telefon"].ToString());
                    if (rdr["Cinsiyet"].ToString() == "False")
                    {
                        Musteriler.Items[i].SubItems.Add("Bay");
                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Bayan");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDateTime(rdr["DogumTarihi"]).ToShortDateString());
                    Musteriler.Items[i].SubItems.Add(Convert.ToInt32(rdr["SehirID"]).ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["SehirAdi"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(rdr["KartNumarasi"].ToString());
                    if (rdr["KartTeslimDurumu"].ToString() == "True")
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edildi");

                    }
                    else
                    {
                        Musteriler.Items[i].SubItems.Add("Teslim Edilmedi");
                    }
                    Musteriler.Items[i].SubItems.Add(Convert.ToDecimal(rdr["MevcutPara"]).ToString());
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

        public static Entity.Musteri KartNumarasinaGoreBilgi(string KartNo)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("KartNoyaGoreMusteriBilgi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KartNumarasi", KartNo);

            Entity.Musteri donecek = null;
            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    donecek = new Entity.Musteri();
                    donecek.Ad = Convert.ToString(rdr["Ad"]);
                    donecek.SoyAd = Convert.ToString(rdr["SoyAd"]);
                    donecek.MusteriID = Convert.ToInt32(rdr["MusteriID"]);
                    donecek.Cinsiyet = Convert.ToBoolean(rdr["Cinsiyet"]);
                    donecek.MevcutPara = Convert.ToDecimal(rdr["MevcutPara"].ToString());

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
            return donecek;
        }
    }
}
