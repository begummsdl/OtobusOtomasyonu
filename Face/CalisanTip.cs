using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Face
{
    public class CalisanTip
    {
        public static int CalisanTipEkle(Entity.CalisanTip cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipAdi", cl.CalisanTipAdi);
            return Util.Yurut(cmd);
        }
        public static int CalisanTipGuncelle(Entity.CalisanTip cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisanTipID);
            cmd.Parameters.AddWithValue("@CalisanTipAdi", cl.CalisanTipAdi);
            return Util.Yurut(cmd);
        }
        public static int CalisanTipSil(Entity.CalisanTip cl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanTipID", cl.CalisanTipID);
            return Util.Yurut(cmd);
        }
        public static Entity.CalisanTip CalisanTipDetayGor(int calisantipID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisnTipID", calisantipID);
            Entity.CalisanTip cl = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                cl = new Entity.CalisanTip();
                cl = new Entity.CalisanTip();
                if (rdr.Read())
                {
                    cl.CalisanTipID = Convert.ToInt32(rdr["CalisanTipID"]);
                    cl.CalisanTipAdi = Convert.ToString(rdr["CalisanTipAdi"]);
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
        public static void CalisanTipGetir(ComboBox CalisanTip)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from CalisanTipleri", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.CalisanTip clt = new Entity.CalisanTip();
                    clt.CalisanTipID = Convert.ToInt32(rdr["CalisanTipID"]);
                    clt.CalisanTipAdi = Convert.ToString(rdr["CalisanTipAdi"]);
                    CalisanTip.Items.Add(clt);
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


        public static void CalisanTipListesi(ListView lsvCalisanTip)
        {
            lsvCalisanTip.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("CalisanTipListesi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    lsvCalisanTip.Items.Add(rdr["CalisanTipID"].ToString());
                    lsvCalisanTip.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
                    i++;
                }
                rdr.Dispose();
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

        public static void CalisanTipAra(ListView lsvCalisanTip, string kelime)
        {
            lsvCalisanTip.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select CalisanTipID,CalisanTipAdi From CalisanTipleri where CalisanTipAdi Like @CalisanTipAd+'%'", cnn);
            cmd.Parameters.AddWithValue("@CalisanTipAd", kelime);
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
                    lsvCalisanTip.Items.Add(rdr["CalisanTipID"].ToString());
                    lsvCalisanTip.Items[i].SubItems.Add(Convert.ToString(rdr["CalisanTipAdi"]));
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

        public static bool CalisanTipAdiVarmi(string kelime)
        {
            bool sonuc = false;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select CalisanTipAdi from CalisanTipleri where CalisanTipAdi=@CalisanTipAd", cnn);
            cmd.Parameters.AddWithValue("@CalisanTipAd", kelime);
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
    }
}
