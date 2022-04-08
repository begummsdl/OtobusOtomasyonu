using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Face
{
    public class PersonelGirisCikis
    {
        public static int PersonelGirisCikisEkle(Entity.PersonelGirisCikis per)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", per.PersonelID);
            cmd.Parameters.AddWithValue("IslemTipi", per.IslemTipi);
            return Util.Yurut(cmd);
        }
        public static int PersonelGirisCikisGuncelle(Entity.PersonelGirisCikis per)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelIslemID", per.PersonelIslemID);
            cmd.Parameters.AddWithValue("@PersonelID", per.PersonelID);
            cmd.Parameters.AddWithValue("@IslemZamani", per.IslemZamani);
            cmd.Parameters.AddWithValue("@IslemTipi", per.IslemTipi);
            return Util.Yurut(cmd);
        }
        public static int PersonelGirisCikisSil(Entity.PersonelGirisCikis per)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelGirisCikisSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PersonelIslemID", per.PersonelIslemID);
            return Util.Yurut(cmd);
        }
        public static Entity.PersonelGirisCikis PersonelAra(int personelID)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("PersonelAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonelID", personelID);
            Entity.PersonelGirisCikis per = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                per = new Entity.PersonelGirisCikis();
                if (rdr.Read())
                {
                    per.PersonelIslemID=Convert.ToInt32(rdr["PersonelIslemID"]);
                        per.PersonelID=Convert.ToInt32(rdr["PersonelID"]);
                            per.IslemZamani=Convert.ToDateTime(rdr["IslemZamani"]);
                            per.IslemTipi = Convert.ToBoolean(rdr["IslemTipi"]);
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
            return per;
        }
    }
}
