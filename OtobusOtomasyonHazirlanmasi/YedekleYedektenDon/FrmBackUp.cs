using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.YedekleYedektenDon
{
    public partial class FrmBackUp : Form
    {
        public FrmBackUp()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.Day + "-" + dateTime.Month;
            string servername = txtServer.Text;
            string dbname = txtDB.Text;

            string connectionstr = @"Data Source=" + servername + ";Initial Catalog=" + dbname + ";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstr);

            connection.Open();

            string str1 = "USE " + dbname + ";";
            string str2 = "BACKUP DATABASE " + dbname +
                " TO DISK = 'C:\\database\\" + dbname + "_" + date +
                ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of " + dbname + "';";
            SqlCommand cmd1 = new SqlCommand(str1, connection);
            SqlCommand cmd2 = new SqlCommand(str2, connection);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti. Yedeklenen dosyaya ulaşmak için (DB ismi.Bak) uzantısını Disk C:\\database\\(DB ismi.Bak) yolunda bulabilirsiniz.");

            connection.Close();
        }
    }
}
