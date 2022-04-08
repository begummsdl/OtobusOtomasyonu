using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Face
{
   public class Hataci
    {
       public static void YeniHataKaydi(SqlException ex)
       {
           SqlConnection cnn = new SqlConnection(Util.cnnstring);
           SqlCommand cmd = new SqlCommand("HataEkle", cnn);
           cmd.CommandType = CommandType.StoredProcedure;

           cmd.Parameters.AddWithValue("@Numara", ex.Number);
           cmd.Parameters.AddWithValue("@Mesaj", ex.Message);
           cmd.Parameters.AddWithValue("@Procedure", ex.Procedure);
           try
           {
               cnn.Open();
               cmd.ExecuteNonQuery();
           }
           catch (SqlException)
           {

           }
           finally
           {
               cnn.Close();
           }
       }
    }
}
