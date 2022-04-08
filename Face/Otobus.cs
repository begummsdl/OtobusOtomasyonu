using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Face
{
    public class Otobus
    {
        public static int OtobusEkle(Entity.Otobus oto)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("OtobusEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Plaka", oto.Plaka);
            cmd.Parameters.AddWithValue("@KoltukSayisi", oto.KoltukSayisi);
            cmd.Parameters.AddWithValue("@MarkaID", oto.MarkaID);
            cmd.Parameters.AddWithValue("@AktifMi", oto.AktifMi);
            return Util.Yurut(cmd);
        }
        public static int OtobusGuncelle(Entity.Otobus oto)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("OtobusGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OtobusID", oto.OtobusID); cmd.Parameters.AddWithValue("@Plaka", oto.Plaka);
            cmd.Parameters.AddWithValue("@KoltukSayisi", oto.KoltukSayisi);
            cmd.Parameters.AddWithValue("@MarkaID", oto.MarkaID);
            cmd.Parameters.AddWithValue("@AktifMi", oto.AktifMi);
            return Util.Yurut(cmd);
        }
        public static int OtobusSil(Entity.Otobus oto)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("OtobusSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OtobusID", oto.OtobusID);
            return Util.Yurut(cmd);
        }
        public static Entity.Otobus OtobusDetayGor(int otobusID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("OtobusDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OtobusID", otobusID);
            Entity.Otobus oto = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                oto = new Entity.Otobus();
                if (rdr.Read())
                {
                    oto.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                    oto.Plaka = Convert.ToString(rdr["Plaka"]);
                    oto.KoltukSayisi = Convert.ToByte(rdr["KoltukSayisi"]);
                    oto.MarkaID = Convert.ToInt32(rdr["MarkaID"]);
                    oto.AktifMi = Convert.ToBoolean(rdr["AktifMi"]);
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
            return oto;
        }

        public static void OtobusListesi(ListView lsvOtobusler)
        {
            lsvOtobusler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Markalar.MarkaAdi, dbo.Otobusler.* FROM  dbo.Otobusler INNER JOIN dbo.Markalar ON dbo.Otobusler.MarkaID = dbo.Markalar.MarkaID", cnn);
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
                    lsvOtobusler.Items.Add(Convert.ToString(rdr["OtobusID"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["Plaka"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["KoltukSayisi"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaID"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaAdi"]));
                    if (Convert.ToString(rdr["AktifMi"]) == "True")
                    {
                        lsvOtobusler.Items[i].SubItems.Add("Evet");
                    }
                    else
                    {
                        lsvOtobusler.Items[i].SubItems.Add("Hayır");
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

        public static bool OtobusVarmi(string plaka)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand(@"Select * from Otobusler where Plaka = @Plaka",cnn);
            cmd.Parameters.AddWithValue("@Plaka", plaka);
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

        public static void PlakayaGoreOtobusAra(ListView lsvOtobusler, string plaka)
        {
            lsvOtobusler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("select Otobusler.*,Markalar.MarkaAdi from Otobusler inner join Markalar on Otobusler.MarkaID=Markalar.MarkaID where Otobusler.Plaka Like @Plaka+'%'", cnn);
            cmd.Parameters.AddWithValue("@Plaka", plaka);
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
                    lsvOtobusler.Items.Add(Convert.ToString(rdr["OtobusID"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["Plaka"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["KoltukSayisi"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaID"]));
                    lsvOtobusler.Items[i].SubItems.Add(Convert.ToString(rdr["MarkaAdi"]));
                    if (Convert.ToString(rdr["AktifMi"]) == "True")
                    {
                        lsvOtobusler.Items[i].SubItems.Add("Evet");
                    }
                    else
                    {
                        lsvOtobusler.Items[i].SubItems.Add("Hayır");
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

        public static void OtobusPlakaGetir(ComboBox cmbOtobus)
        {
            cmbOtobus.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select OtobusID,Plaka from Otobusler", cnn);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Entity.Otobus otobus = new Entity.Otobus();
                otobus.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                otobus.Plaka = Convert.ToString(rdr["Plaka"]);
                cmbOtobus.Items.Add(otobus);
                //Turler.Items.Add(dr["TurAd"]);
            }
            rdr.Close();
            cnn.Close();
        }
    }
}
