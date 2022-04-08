using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Face
{
    public class MasrafTip
    {
        public static int MasrafTipEkle(Entity.MasrafTip mt)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MasrafTipAdi", mt.MasrafTipAdi);
            return Util.Yurut(cmd);
        }
        public static int MasrafTipGuncelle(Entity.MasrafTip mt)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MasrafTipID", mt.MasrafTipID);
            cmd.Parameters.AddWithValue("@MasrafTipAdi", mt.MasrafTipAdi);
            return Util.Yurut(cmd);
        }
        public static int MasrafTipSil(Entity.MasrafTip mt)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MasrafTipID", mt.MasrafTipID);
            return Util.Yurut(cmd);
        }
        public static Entity.MasrafTip MasrafTipDetayGor(int masrafTipID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MasrafTipID", masrafTipID);
            Entity.MasrafTip mt = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                mt = new Entity.MasrafTip();
                if (rdr.Read())
                {
                    mt.MasrafTipID = Convert.ToInt32(rdr["MasrafTipID"]);
                    mt.MasrafTipAdi = Convert.ToString(rdr["MasrafTipAdi"]);
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
            return mt;
        }

        public static void MasrafTipListesi(ListView lsvmasraftip)
        {
            lsvmasraftip.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipListesi", cnn);
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
                    lsvmasraftip.Items.Add(Convert.ToString(rdr["MasrafTipID"]));
                    lsvmasraftip.Items[i].SubItems.Add(Convert.ToString(rdr["MasrafTipAdi"]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { cnn.Close(); }
        }

        public static void MasrafTipDetayGor(ListView lsvMasrafDetay, string MasrafTipID)
        {
            lsvMasrafDetay.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.MasrafTipleri.MasrafTipID, dbo.MasrafTipleri.MasrafTipAdi, dbo.OtobusMasraflar.SeferID, dbo.OtobusMasraflar.Tutar,  dbo.OtobusMasraflar.MasrafYapanPersonelID, dbo.Calisanlar.Ad + ' ' + dbo.Calisanlar.Soyad AS CalisanAdSoyad, dbo.Seferler.SoforID, dbo.Sehirler.SehirAdi,   dbo.Seferler.KalkisSehirID FROM  dbo.MasrafTipleri INNER JOIN dbo.OtobusMasraflar ON dbo.MasrafTipleri.MasrafTipID = dbo.OtobusMasraflar.MasrafTipID INNER JOIN dbo.Seferler ON dbo.OtobusMasraflar.SeferID = dbo.Seferler.SeferID INNER JOIN dbo.Calisanlar ON dbo.Seferler.SoforID = dbo.Calisanlar.PersonelID INNER JOIN dbo.Sehirler ON dbo.Seferler.KalkisSehirID = dbo.Sehirler.SehirID where dbo.MasrafTipleri.MasrafTipID=@MasTipID ", cnn);
            cmd.Parameters.AddWithValue("@MasTipID", MasrafTipID);
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
                    lsvMasrafDetay.Items.Add(Convert.ToString(rdr["MasrafTipID"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["MasrafTipAdi"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["SeferID"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["Tutar"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["MasrafYapanPersonelID"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanAdSoyad"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["SoforID"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["SehirAdi"]));
                    lsvMasrafDetay.Items[i].SubItems.Add(Convert.ToString(rdr["KalkisSehirID"]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { cnn.Close(); }
        }

        public static bool MasrafTipAdiVarmi(string mtadi)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select MasrafTipAdi From MasrafTipleri where MasraTipAdi =@MtAdi", cnn);
            cmd.Parameters.AddWithValue("@MtAdi", mtadi);
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
            finally { cnn.Close(); }
            return sonuc;
        }

        public static void MasrafTipListe(ComboBox cmbMasrafTip)
        {
            cmbMasrafTip.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipListesi", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.MasrafTip mt = new Entity.MasrafTip();
                    mt.MasrafTipID = Convert.ToInt32(rdr["MasrafTipID"]);
                    mt.MasrafTipAdi = Convert.ToString(rdr["MasrafTipAdi"]);
                    cmbMasrafTip.Items.Add(mt);
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



        public static void MasrafAdiAra(ListView lsvMasrafTip, string masrafad)
        {
            lsvMasrafTip.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand(@"Select * from MasrafTipleri where MasrafTipAdi like @Madi+'%'", cnn);
            cmd.Parameters.AddWithValue("@Madi", masrafad);
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
                    lsvMasrafTip.Items.Add(Convert.ToString(rdr["MasrafTipID"]));
                    lsvMasrafTip.Items[i].SubItems.Add(Convert.ToString(rdr["MasrafTipAdi"]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { cnn.Close(); }
        }

        public static void MasrafTipiGetir(ComboBox cmbOtobusMasrafAdi)
        {
            cmbOtobusMasrafAdi.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MasrafTipListesi", cnn);
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
                    Entity.MasrafTip mt = new Entity.MasrafTip();
                    mt.MasrafTipID = Convert.ToInt32(rdr["MasrafTipID"]);
                    mt.MasrafTipAdi = Convert.ToString(rdr["MasrafTipAdi"]);
                    cmbOtobusMasrafAdi.Items.Add(mt);

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
