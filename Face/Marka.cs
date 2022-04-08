using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Face
{
    public class Marka
    {
        public static int MarkaEkle(Entity.Marka mk)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MarkaEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MarkaAdi", mk.MarkaAdi);
            return Util.Yurut(cmd);
        }
        public static int MarkaGuncelle(Entity.Marka mk)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MarkaGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MarkaID", mk.MarkaID);
            cmd.Parameters.AddWithValue("@MarkaAdi", mk.MarkaAdi);

            return Util.Yurut(cmd);
        }
        public static int MarkaSil(Entity.Marka mk)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MarkaSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MarkaID", mk.MarkaID);
            return Util.Yurut(cmd);
        }
        public static Entity.Marka MarkaDetayGor(int markaID)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MarkaDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MarkaID", markaID);
            Entity.Marka mk = null;
            try
            {
                if (cnn.State == ConnectionState.Closed) 
                {
                    cnn.Open();
                }

                SqlDataReader rdr = cmd.ExecuteReader();
                mk = new Entity.Marka();
                if (rdr.Read())
                {
                    mk.MarkaID = Convert.ToInt32(rdr["MarkaID"]);
                    mk.MarkaAdi = Convert.ToString(rdr["MarkaAdi"]);
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
            return mk;
        }

        public static void MarkaListele(ComboBox markagetir)
        {
            markagetir.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Markalar", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr=cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Marka mk = new Entity.Marka();
                    mk.MarkaID = Convert.ToInt32(rdr["MarkaID"]);
                    mk.MarkaAdi = Convert.ToString(rdr["MarkaAdi"]);
                    markagetir.Items.Add(mk);
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

        public static void MarkaListesi(ListView lsvMarka)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand(@"SELECT  dbo.Markalar.*, dbo.Otobusler.Plaka, dbo.Otobusler.KoltukSayisi, dbo.Otobusler.OtobusID, dbo.Otobusler.AktifMi FROM dbo.Markalar INNER JOIN dbo.Otobusler ON dbo.Markalar.MarkaID = dbo.Otobusler.MarkaID",cnn);
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
                    lsvMarka.Items.Add(Convert.ToString(rdr["MarkaID"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaAdi"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["Plaka"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["KoltukSayisi"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["OtobusID"]));
                    if (rdr["AktifMi"].ToString() == "True")
                    {
                        lsvMarka.Items[i].SubItems.Add("Evet");
                    }
                    else
                    {
                        lsvMarka.Items[i].SubItems.Add("Hayır");
                    }
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

        public static void MarkadakiOtobusSayisi(string MarkaAdi,TextBox sayi)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand(@"Select COUNT(Markalar.MarkaID) as OtobusSayisi, Markalar.MarkaAdi from Markalar inner join Otobusler on Otobusler.MarkaID=Markalar.MarkaID group by Markalar.MarkaAdi having Markalar.MarkaAdi=@MarkaAdi", cnn);
            cmd.Parameters.AddWithValue("@MarkaAdi", MarkaAdi);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sayi.Text = rdr["OtobusSayisi"].ToString();
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

        public static void MarkaAdiAra(ListView lsvMarka, string markaAd)
        {
            lsvMarka.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Markalar.MarkaID,dbo.Markalar.MarkaAdi, dbo.Otobusler.OtobusID, dbo.Otobusler.Plaka, dbo.Otobusler.KoltukSayisi, dbo.Otobusler.AktifMi FROM dbo.Markalar INNER JOIN dbo.Otobusler ON dbo.Markalar.MarkaID = dbo.Otobusler.MarkaID where Markalar.MarkaAdi like @MarkaAdi+'%'", cnn);
            cmd.Parameters.AddWithValue("@MarkaAdi",markaAd);
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
                    lsvMarka.Items.Add(Convert.ToString(rdr["MarkaID"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaAdi"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["Plaka"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["KoltukSayisi"]));
                    lsvMarka.Items[i].SubItems.Add(Convert.ToString(rdr["OtobusID"]));
                    if (rdr["AktifMi"].ToString() == "True")
                    {
                        lsvMarka.Items[i].SubItems.Add("Evet");
                    }
                    else
                    {
                        lsvMarka.Items[i].SubItems.Add("Hayır");
                    }
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

        public static void MarkaListGor(ListBox lstMarka)
        {
            lstMarka.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Markalar", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Marka mk = new Entity.Marka();
                    mk.MarkaID = Convert.ToInt32(rdr["MarkaID"]);
                    mk.MarkaAdi = Convert.ToString(rdr["MarkaAdi"]);
                    lstMarka.Items.Add(mk);
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

        public static bool MarkaVarmi(string kelime)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Markalar where MarkaAdi =@MarkaAdi", cnn);
            cmd.Parameters.AddWithValue("@MarkaAdi", kelime);
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
    }
}
