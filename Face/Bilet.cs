using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Face
{
    public class Bilet
    {
        public static int BiletEkle(Entity.Bilet bl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("BiletEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IslemYapanPersonelID", bl.IslemYapanPersonelID);
            cmd.Parameters.AddWithValue("@YolcuID", bl.YolcuID);
            cmd.Parameters.AddWithValue("@SeferID", bl.SeferID);
            cmd.Parameters.AddWithValue("@IslemZamani", bl.IslemZamani);
            cmd.Parameters.AddWithValue("@SatismiRezervasyonMu", bl.SatisMiRezervasyonMu);
            cmd.Parameters.AddWithValue("@KoltukNo", bl.KoltukNo);
            cmd.Parameters.AddWithValue("@YolcuCinsiyet", bl.YolcuCinsiyet);
            cmd.Parameters.AddWithValue("@Yolcuad", bl.YolcuAd);
            cmd.Parameters.AddWithValue("@YolcuSoyad", bl.YolcuSoyad);
            cmd.Parameters.AddWithValue("@SatisTip", bl.SatisTip);
            cmd.Parameters.AddWithValue("@Ucret", bl.Ucret);
            return Util.Yurut(cmd);
        }
        public static int BiletGuncelle(Entity.Bilet bl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("BiletGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IslemYapanPersonelID", bl.IslemYapanPersonelID);
            cmd.Parameters.AddWithValue("@YolcuID", bl.YolcuID);
            cmd.Parameters.AddWithValue("@SeferID", bl.SeferID);
            cmd.Parameters.AddWithValue("@IslemZamani", bl.IslemZamani);
            cmd.Parameters.AddWithValue("@SatismiRezervasyonMu", bl.SatisMiRezervasyonMu);
            cmd.Parameters.AddWithValue("@KoltukNo", bl.KoltukNo);
            cmd.Parameters.AddWithValue("@YolcuCinsiyet", bl.YolcuCinsiyet);
            cmd.Parameters.AddWithValue("@Yolcuad", bl.YolcuAd);
            cmd.Parameters.AddWithValue("@YolcuSoyad", bl.YolcuSoyad);
            cmd.Parameters.AddWithValue("@SatisTip", bl.SatisTip);
            cmd.Parameters.AddWithValue("@Ucret", bl.Ucret);
            return Util.Yurut(cmd);
        }
        public static int BiletSil(Entity.Bilet bl)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("BiletSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", bl.SeferID);
            cmd.Parameters.AddWithValue("@KoltukNo", bl.KoltukNo);
            return Util.Yurut(cmd);
        }
        public static Entity.Bilet BiletDetay(int seferID, byte koltukNo)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("BiletDetay", cnn);

            cmd.CommandType = CommandType.StoredProcedure;

            Entity.Bilet bilet = null;
            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    bilet = new Entity.Bilet();
                    bilet.IslemYapanPersonelID = Convert.ToInt32(rdr["IslemYapanPersonelID"]);
                    bilet.YolcuID = Convert.ToInt32(rdr["YolcuID"]);
                    bilet.SeferID = Convert.ToInt32(rdr["SeferID"]);
                    bilet.IslemZamani = Convert.ToDateTime(rdr["IslemZamani"]);
                    bilet.SatisMiRezervasyonMu = Convert.ToBoolean(rdr["SatisMiRezervasyonMu"]);
                    bilet.KoltukNo = Convert.ToByte(rdr["KoltukNo"]);
                    bilet.YolcuCinsiyet = Convert.ToBoolean(rdr["YolcuCinsiyet"]);
                    bilet.YolcuAd = rdr["YolcuAd"].ToString();
                    bilet.YolcuSoyad = rdr["YolcuSoyAd"].ToString();
                    bilet.SatisTip = Convert.ToBoolean(rdr["SatisTip"]);
                    bilet.Ucret = (decimal)rdr["Ucret"];
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
            return bilet;
        }

        public static int RezervasyonuSatisaCevir(Entity.Bilet bilet)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("RezervasyonSatisaCevir", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SeferID", bilet.SeferID);
            cmd.Parameters.AddWithValue("@KoltukNo", bilet.KoltukNo);

            return Util.Yurut(cmd);
        }

        public static int SatisIptal(Entity.Bilet bilet)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SatisIptal", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SeferID", bilet.SeferID);
            cmd.Parameters.AddWithValue("@KoltukNo", bilet.KoltukNo);

            return Util.Yurut(cmd);
        }

        public static bool MusteriParaGuncelle(int MusteriID, decimal Ucret)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Update Musteriler set MevcutPara-=@Ucret where MusteriID=@MusteriID", cnn);
            cmd.Parameters.AddWithValue("@Ucret", Ucret);
            cmd.Parameters.AddWithValue("@MusteriID", MusteriID);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            bool sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            return sonuc;
        }
        public static void MusteriParasınıYaz(TextBox txt)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Musteriler", cnn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txt.Text = Convert.ToString(rdr["MevcutPara"]);
            }
            rdr.Close();
            cnn.Close();
        }

    }
}
