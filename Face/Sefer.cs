using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Face
{
    public class Sefer
    {
        public static int SeferEkle(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KalkisSehirID", sf.KalkisSehirID);
            cmd.Parameters.AddWithValue("@VarisSehirID", sf.VarisSehirID);
            cmd.Parameters.AddWithValue("@OtobusID", sf.OtobusID);
            cmd.Parameters.AddWithValue("@SoforID", sf.SoforID);
            cmd.Parameters.AddWithValue("@MuavinID", sf.MuavinID);
            cmd.Parameters.AddWithValue("@KalkisZamani", sf.KalkisZamani);
            cmd.Parameters.AddWithValue("@VarisZamani", sf.VarisZamani);
            cmd.Parameters.AddWithValue("@TahminiSure", sf.TahminiSure);
            cmd.Parameters.AddWithValue("@BiletTutari", sf.BiletTutari);

            return Util.Yurut(cmd);
        }
        public static int SeferGuncelle(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", sf.SeferID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KalkisSehirID", sf.KalkisSehirID);
            cmd.Parameters.AddWithValue("@VarisSehirID", sf.VarisSehirID);
            cmd.Parameters.AddWithValue("@OtobusID", sf.OtobusID);
            cmd.Parameters.AddWithValue("@SoforID", sf.SoforID);
            cmd.Parameters.AddWithValue("@MuavinID", sf.MuavinID);
            cmd.Parameters.AddWithValue("@KalkisZamani", sf.KalkisZamani);
            cmd.Parameters.AddWithValue("@VarisZamani", sf.VarisZamani);
            cmd.Parameters.AddWithValue("@TahminiSure", sf.TahminiSure);
            cmd.Parameters.AddWithValue("@BiletTutari", sf.BiletTutari);

            return Util.Yurut(cmd);
        }
        public static int SeferSil(Entity.Sefer sf)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", sf.SeferID);
            return Util.Yurut(cmd);
        }
        public static Entity.Sefer SeferDetayGoruntule(int seferID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SeferDetay", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", seferID);
            Entity.Sefer sf = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                sf = new Entity.Sefer();
                if (rdr.Read())
                {
                    sf.KalkisSehirID = Convert.ToInt32(rdr["KalkisSehirID"]);
                    sf.VarisSehirID = Convert.ToInt32(rdr["VarisSehirID"]);
                    sf.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                    sf.SoforID = Convert.ToInt32(rdr["SoforID"]);
                    sf.MuavinID = Convert.ToInt32(rdr["MuavinID"]);
                    sf.KalkisZamani = Convert.ToDateTime(rdr["KalkisZamani"]);
                    sf.VarisZamani = Convert.ToDateTime(rdr["VarisZamani"]);
                    sf.TahminiSure = Convert.ToByte(rdr["TahminiSure"]);
                    sf.BiletTutari = Convert.ToDecimal(rdr["BiletTutari"]);
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
            return sf;
        }

        public static void SeferDoldur(TextBox txtKalkisID, TextBox txtVarisID, TextBox txtSeferID)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select SeferID,KalkisSehirID,VarisSehirID from Seferler where SeferID=@SeferID", cnn);
            cmd.Parameters.AddWithValue("@SeferID", txtSeferID.Text);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    txtSeferID.Text = Convert.ToString(rdr["SeferID"]);
                    txtKalkisID.Text = Convert.ToString(rdr["KalkisSehirID"]);
                    txtVarisID.Text = Convert.ToString(rdr["VarisSehirID"]);


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

        public static void KalkisSehirAdiGetir(string SeferID, TextBox kalkilanSehirAd)
        {

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("sELECT Sehirler.SehirAdi,Seferler.SeferID FROM Seferler inner join Sehirler on Sehirler.SehirID=Seferler.KalkisSehirID where Seferler.SeferID=@SeferID", cnn);
            cmd.Parameters.AddWithValue("@SeferID", SeferID);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    kalkilanSehirAd.Text = Convert.ToString(rdr["SehirAdi"]);
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

        public static void VarisSehirAdiGetir(string SeferID, TextBox txtVarisSehiri)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("sELECT Sehirler.SehirAdi,Seferler.SeferID FROM Seferler inner join Sehirler on Sehirler.SehirID=Seferler.VarisSehirID where Seferler.SeferID=@SeferID", cnn);
            cmd.Parameters.AddWithValue("@SeferID", SeferID);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtVarisSehiri.Text = Convert.ToString(rdr["SehirAdi"]);
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

        public static void Seferlistesi(ComboBox cmbSefer)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Seferler", cnn);
            try
            {
                cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Sefer sf = new Entity.Sefer();
                    sf.SeferID = Convert.ToInt32((rdr["SeferID"]));
                    cmbSefer.Items.Add(sf);
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

        public static void SoforAdBulGetir(ComboBox calisanSofor)
        {
            calisanSofor.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT PersonelID,Ad FROM Calisanlar where CalisanTipID=3", cnn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Calisan cl = new Entity.Calisan();
                    cl.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    cl.Ad = rdr["Ad"].ToString();
                    calisanSofor.Items.Add(cl);

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

        public static void MuavinAdBulGetir(ComboBox cmbCalisanMuavin)
        {
            cmbCalisanMuavin.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT PersonelID,Ad from Calisanlar where CalisanTipID=4", cnn);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Calisan cl = new Entity.Calisan();
                    cl.PersonelID = Convert.ToInt32(rdr["PersonelID"]);
                    cl.Ad = rdr["Ad"].ToString();
                    cmbCalisanMuavin.Items.Add(cl);

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

        public static void OtobusPlakaBulGetir(ComboBox cmbOtobusler)
        {
            cmbOtobusler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select OtobusID,Plaka from Otobusler", cnn);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Otobus oto = new Entity.Otobus();
                    oto.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                    oto.Plaka = rdr["Plaka"].ToString();
                    cmbOtobusler.Items.Add(oto);

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

        public static DataSet SeferListele()
        {
            DataSet ds = new DataSet();

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlDataAdapter adp = new SqlDataAdapter("SeferListeBirlestirDetay", cnn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                adp.Fill(ds, "DetayListesi");
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }


            return ds;
        }

        public static DataSet SeferNoyaGoreAra(int KalkisID, int VarisID)
        {
            DataSet ds = new DataSet();

            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlDataAdapter adp = new SqlDataAdapter("SeferListeAraGetir", cnn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@KalkisSehirID", KalkisID);
            adp.SelectCommand.Parameters.AddWithValue("@VarisSehirID", VarisID);
            try
            {
                adp.Fill(ds, "Ara");
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }


            return ds;
        }

        public static DataTable BileTSatiMevcutSeferler(int KalkisSehirıID, int VarisSehirID, DateTime KalkisZamani)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("MevcutSeferler", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KalkisSehirID", KalkisSehirıID);
            cmd.Parameters.AddWithValue("@VarisSehirID", VarisSehirID);
            cmd.Parameters.AddWithValue("@Tarih", KalkisZamani);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            return dt;
        }

        public static DataTable SefereGoreKoltukNumaralari(int SeferID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SefereGoreKoltukNumaralari", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeferID", SeferID);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public static DataTable TarihBazliSeferRapor(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            SqlConnection con = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("TarihBazliSeferRapor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi); 
            cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt); 
            return dt;
        }

        public static DataTable SehirBazliSeferRapor(int kalkisSehirId, int variSehirId)
        {
            SqlConnection con = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SehirBazliSeferRapor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KalkisSehri", kalkisSehirId);
            cmd.Parameters.AddWithValue("@VarisSehri", variSehirId);

            SqlDataAdapter da = new SqlDataAdapter(cmd); DataTable dt = new DataTable(); da.Fill(dt);

            return dt;

        }
    }
}
