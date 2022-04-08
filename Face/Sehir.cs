using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;
namespace Face
{
    public class Sehir
    {
        public static int SehirEkle(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirAdi", sh.SehirAdi);
            return Util.Yurut(cmd);

        }
        public static int SehirGuncelle(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirID", sh.SehirID);
            cmd.Parameters.AddWithValue("@SehirAdi", sh.SehirAdi);
            return Util.Yurut(cmd);
        }
        public static int SehirSil(Entity.Sehir sh)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirID", sh.SehirID);

            return Util.Yurut(cmd);
        }
        public static void SehirListesi(ListView lsvSehir)
        {
            lsvSehir.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirListesi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

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
                    lsvSehir.Items.Add(rdr["SehirID"].ToString());
                    lsvSehir.Items[i].SubItems.Add(Convert.ToString(rdr["SehirAdi"]));
                    i++;
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
        }
        public static Entity.Sehir SehirDetayGoruntule(int sehirID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirID", sehirID);
            Entity.Sehir sh = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                sh = new Entity.Sehir();
                if (rdr.Read())
                {
                    sh.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    sh.SehirAdi = Convert.ToString(rdr["SehirAdi"]);

                }
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);

                //string hata = ex.Message;

            }
            finally
            {
                cnn.Close();
            }
            return sh;
        }
        public static bool SehirVarmi(string sehirAdi)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from  Sehirler where SehirAdi=@SehirAdi", cnn);

            cmd.Parameters.AddWithValue("@SehirAdi", sehirAdi);
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

        public static void sehirListele(ComboBox cmbSehir)
        {
            cmbSehir.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirListesi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Sehir sh = new Entity.Sehir();
                    sh.SehirID = Convert.ToInt32(rdr["SehirID"]);
                    sh.SehirAdi = Convert.ToString(rdr["SehirAdi"]);
                    cmbSehir.Items.Add(sh);
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
        }

        public static void ArananSehir(ListView lsvSehir, string SehirAd)
        {
            lsvSehir.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand(@"Select * from Sehirler where SehirAdi Like @SehirAdi+'%' ", cnn);
            cmd.Parameters.AddWithValue("@SehirAdi", SehirAd);
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
                    lsvSehir.Items.Add(Convert.ToString(rdr["SehirID"]));
                    lsvSehir.Items[i].SubItems.Add(Convert.ToString(rdr["SehirAdi"]));
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

        public static void SehirAdinaGoreOtobusSayisi(string sehirAdi,TextBox otobusayisi)
        {
            otobusayisi.Text = "";
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT( dbo.Otobusler.OtobusID)as OtobusSayisi,dbo.Sehirler.*, dbo.Seferler.KalkisSehirID FROM  dbo.Seferler INNER JOIN  dbo.Sehirler ON dbo.Seferler.KalkisSehirID = dbo.Sehirler.SehirID  INNER JOIN  dbo.Otobusler ON dbo.Seferler.OtobusID = dbo.Otobusler.OtobusID group by Sehirler.SehirAdi,Sehirler.SehirID,dbo.Seferler.KalkisSehirID, dbo.Otobusler.OtobusID having Sehirler.SehirAdi=@SehirAdi", cnn);
            cmd.Parameters.AddWithValue("@SehirAdi", sehirAdi);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {  
                        otobusayisi.Text = Convert.ToString(rdr["OtobusSayisi"]);
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

        public static void SehirGetir(ComboBox Turler)
        {
            Turler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirListesi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Entity.Sehir sehir = new Entity.Sehir();
                sehir.SehirID = Convert.ToInt32(dr["SehirID"]);
                sehir.SehirAdi = Convert.ToString(dr["SehirAdi"]);

                Turler.Items.Add(sehir);
                //Turler.Items.Add(dr["TurAd"]);
            }
            dr.Close();
            cnn.Close();
        }
    }
}
