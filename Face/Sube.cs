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
    public class Sube
    {
        public static int SubeEkle(Entity.Sube sube)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SubeEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubeAdi", sube.SubeAdi);
            cmd.Parameters.AddWithValue("@SehirID", sube.SehirID);
            return Util.Yurut(cmd);

        }
        public static int SubeGuncelle(Entity.Sube sube)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SubeGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SehirID", sube.SehirID);
            cmd.Parameters.AddWithValue("@SubeAdi", sube.SubeAdi);
            cmd.Parameters.AddWithValue("@SubeID", sube.SubeID);
            return Util.Yurut(cmd);
        }
        public static int SubeSil(Entity.Sube sube)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SubeSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubeID", sube.SubeID);
            return Util.Yurut(cmd);
        }
        
        public static Entity.Sube SubeDetayGoruntule(int subeID)
        {
         SqlConnection cnn = new SqlConnection(Util.cnnstring);
         SqlCommand cmd = new SqlCommand("SubeDetay", cnn);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("@SubeID", subeID);
         Entity.Sube sb = null;
         try
         {
             if (cnn.State == ConnectionState.Closed)
             {
                 cnn.Open();
             }
             SqlDataReader rdr = cmd.ExecuteReader();
             sb = new Entity.Sube();
             if (rdr.Read())
             {
                 sb.SehirID = Convert.ToInt32(rdr["SehirID"]);
                 sb.SubeAdi = rdr["SubeAdi"].ToString();
                 sb.SubeID = Convert.ToInt32(rdr["SubeID"]);
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
         return sb;
        }
        public static bool SubeVarmi(string subeAdi)
        {
            bool sonuc = false;
          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlCommand cmd = new SqlCommand("Select * from Subeler where SubeAdi=@SubeAdi", cnn);
          cmd.Parameters.AddWithValue("@SubeAdi", subeAdi);
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

        public static void Subelistele(ComboBox Subler)
        {
            Subler.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Subeler", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Sube sub = new Entity.Sube();
                    sub.SubeID = Convert.ToInt32(rdr["SubeID"]);
                    sub.SubeAdi = Convert.ToString(rdr["SubeAdi"]);
                    Subler.Items.Add(sub);
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

        public static void SubeListesi(ListView lsvSube)
        {
            lsvSube.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT dbo.Subeler.*, dbo.Sehirler.SehirAdi FROM  dbo.Subeler INNER JOIN dbo.Sehirler ON dbo.Subeler.SehirID = dbo.Sehirler.SehirID",cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = Convert.ToString(rdr["SubeID"]);
                    li.SubItems.Add(Convert.ToString(rdr["SehirID"]));
                    li.SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    li.SubItems.Add(Convert.ToString(rdr["SehirAdi"]));
                    lsvSube.Items.Add(li);
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

        public static void SubeDetayiVeCalisanSayisi(string SubeID, Label lblSubeID, Label lblSubeAdi, Label lblSehirID, Label lblSehirAdi, Label lblCalisanSayisi)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT  dbo.Subeler.SubeID, dbo.Subeler.SehirID, dbo.Subeler.SubeAdi, dbo.Sehirler.SehirAdi, COUNT(dbo.Calisanlar.PersonelID) AS calisansayisi FROM  dbo.Subeler INNER JOIN dbo.Sehirler ON dbo.Subeler.SehirID = dbo.Sehirler.SehirID INNER JOIN dbo.Calisanlar ON dbo.Subeler.SubeID = dbo.Calisanlar.SubeID GROUP BY  dbo.Subeler.SubeID, dbo.Subeler.SehirID, dbo.Subeler.SubeAdi, dbo.Sehirler.SehirAdi having dbo.Subeler.SubeID=@SubeID", cnn);
            cmd.Parameters.AddWithValue("@SubeID", SubeID);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                  lblSubeID.Text= Convert.ToString(rdr["SubeID"]);
                  lblSubeAdi.Text = Convert.ToString(rdr["SubeAdi"]);
                  lblSehirID.Text = Convert.ToString(rdr["SehirID"]);
                  lblSehirAdi.Text = Convert.ToString(rdr["SehirAdi"]);
                  lblCalisanSayisi.Text = Convert.ToString(rdr["calisansayisi"]);
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

        public static void SubeAra(ListView lsvSube, string SubeAdi)
        {
            lsvSube.Items.Clear();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SubeAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubeAdi", SqlDbType.NVarChar).Value = SubeAdi;
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
                    lsvSube.Items.Add(Convert.ToString(rdr["SubeID"]));
                    lsvSube.Items[i].SubItems.Add(Convert.ToString(rdr["SehirID"]));
                    lsvSube.Items[i].SubItems.Add(Convert.ToString(rdr["SubeAdi"]));
                    lsvSube.Items[i].SubItems.Add(Convert.ToString(rdr["SehirAdi"]));
                  
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
    }
}
