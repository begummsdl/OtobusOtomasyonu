using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Face
{
    public class Util
    {
        /*
         İşlem Basarılı ise 1 döndürecek metod 
         işlem herhangi degeri etkilemezse 0 döndürecek
         işlem de hata meydana gelirse -1 geri dönecek
         */
        public static string cnnstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OtobusOtomasyon;Integrated Security=True";

        public static int Yurut(SqlCommand cmd)
        {
            int etkilenensatirsayisi = -1;
            try
            {
                cmd.Connection.Open();
               etkilenensatirsayisi= cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Hataci.YeniHataKaydi(ex);
              
            }
            finally
            {
                cmd.Connection.Close();
            }
            return etkilenensatirsayisi;
        }
    }
}
