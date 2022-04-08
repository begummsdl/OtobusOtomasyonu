using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Face
{
  public  class OtobusMasraf
    {
      public static int OtobusMasrafEkle(Entity.OtobusMasraf otm)
      {
          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlCommand cmd = new SqlCommand("OtobusMasrafEkle", cnn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@OtobusID", otm.OtobusID);
          cmd.Parameters.AddWithValue("@MasrafTipID", otm.MasrafipID);
          cmd.Parameters.AddWithValue("@Tutar", otm.Tutar);
          cmd.Parameters.AddWithValue("@MasrafYapanPersonelID", otm.MasrafYapanPersonelID);
          cmd.Parameters.AddWithValue("@SeferID", otm.SeferID);
          return Util.Yurut(cmd);
      }
      public static int OtobusMasrafGuncelle(Entity.OtobusMasraf otm)
      {
          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlCommand cmd = new SqlCommand("OtobusMasrafGuncelle", cnn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@OtobusMasrafID", otm.OtobusMasrafID);
          cmd.Parameters.AddWithValue("@OtobusID", otm.OtobusID);
          cmd.Parameters.AddWithValue("@MasrafTipID", otm.MasrafipID);
          cmd.Parameters.AddWithValue("@Tutar", otm.Tutar);
          cmd.Parameters.AddWithValue("@MasrafYapanPersonelID", otm.MasrafYapanPersonelID);
          cmd.Parameters.AddWithValue("@SeferID", otm.SeferID);
          return Util.Yurut(cmd);
      }
      public static int OtobusMasrafSil(Entity.OtobusMasraf otm)
      {
          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlCommand cmd = new SqlCommand("OtobusMasrafSil", cnn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@OtobusMasrafID", otm.OtobusMasrafID);
          return Util.Yurut(cmd);
      }
      public static Entity.OtobusMasraf OtobusMasrafDetayGor(int otobusMasrafID)
      {
          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlCommand cmd = new SqlCommand("OtobusMasrafDetay", cnn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@OtobusMasrafID", otobusMasrafID);
          Entity.OtobusMasraf otm = null;
          try
          {
              if (cnn.State == ConnectionState.Closed)
              {
                  cnn.Open();
              }
              SqlDataReader rdr = cmd.ExecuteReader();
              otm = new Entity.OtobusMasraf();
              if (rdr.Read())
              {
                  otm.OtobusMasrafID = Convert.ToInt32(rdr["OtobusMasrafID"]);
                  otm.OtobusID = Convert.ToInt32(rdr["OtobusID"]);
                  otm.MasrafipID = Convert.ToInt32(rdr["MasrafTipID"]);
                  otm.Tutar = Convert.ToDecimal(rdr["Tutar"]);
                  otm.MasrafYapanPersonelID = Convert.ToInt32(rdr["MasrafYapanPersonelID"]);
                  otm.SeferID = Convert.ToInt32(rdr["SeferID"]);
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
          return otm;
      }

      public static DataSet OtobusMasrafListeleGrd()
      {
          DataSet ds = new DataSet();

          SqlConnection cnn = new SqlConnection(Util.cnnstring);
          SqlDataAdapter adp = new SqlDataAdapter("SELECT dbo.OtobusMasraflar.*, dbo.Otobusler.Plaka, dbo.Seferler.SoforID,Calisanlar.Ad,Calisanlar.Soyad FROM dbo.OtobusMasraflar INNER JOIN dbo.Otobusler ON dbo.OtobusMasraflar.OtobusID = dbo.Otobusler.OtobusID INNER JOIN dbo.Seferler ON dbo.OtobusMasraflar.SeferID = dbo.Seferler.SeferID AND dbo.Otobusler.OtobusID = dbo.Seferler.OtobusID inner join Calisanlar on Calisanlar.PersonelID =OtobusMasraflar.MasrafYapanPersonelID", cnn);

          try
          {
              adp.Fill(ds, "OtoMasrafGor");
          }
          catch (SqlException ex)
          {

              string hata = ex.Message;
          }


          return ds;
      }
    }
}
