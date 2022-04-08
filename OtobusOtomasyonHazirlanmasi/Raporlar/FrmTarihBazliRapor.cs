using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.Raporlar
{
    public partial class FrmTarihBazliRapor : Form
    {
        public FrmTarihBazliRapor()
        {
            InitializeComponent();
        }

        private void FrmTarihBazliRapor_Load(object sender, EventArgs e)
        {
            dgRaporSonuc.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            dgRaporSonuc.DataSource = Face.Sefer.TarihBazliSeferRapor(dtBaslangicZamani.Value, dtBitisZamani.Value);
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            if (dgRaporSonuc.DataSource != null)
            {
                printPreviewDialog1.ShowDialog();
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dgRaporSonuc.DataSource != null)
            {
                printDocument1.Print();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgRaporSonuc.DataSource != null)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    OleDbConnection excelConnection = new OleDbConnection("Data Source =" + folderBrowserDialog1.SelectedPath
                        + "\\TarihBazlıRapor.xlsx; Provider = Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml; HDR = YES'");

                    OleDbCommand excelCommand = new OleDbCommand("CREATE TABLE[Rapor]([Kalkış] string, [Varış] string, [Varış Zamanı] string, [Kalkış Zamanı] string,[Bilet Tutarı] double, [Toplam Bilet] int);", excelConnection);
                    excelConnection.Open();
                    try
                    {
                        excelCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bu belge zaten mevcut.");
                        return;
                    }
                    excelConnection.Close();
                    excelConnection.Open();
                    DataTable dt = (DataTable)dgRaporSonuc.DataSource;

                    foreach (DataRow dr in dt.Rows)
                    {

                        excelCommand = new OleDbCommand("Insert Into[Rapor$]([Kalkış],[Varış],[Varış Zamanı],[Kalkış Zamanı],[Bilet Tutarı], [Toplam Bilet]) Values(@KalkisSehri,@VarisSehri, @VarisZamani, @KalkisZamani, @BiletTutari,@SatisiYapilanBiletSayisi)", excelConnection);

                        excelCommand.Parameters.AddWithValue("@KalkisSehri", dr["KalkisSehri"].ToString());
                        excelCommand.Parameters.AddWithValue("@VarisSehri", dr["VarisSehri"].ToString());
                        excelCommand.Parameters.AddWithValue("@VarisZamani", dr["VarisZamani"].ToString());
                        excelCommand.Parameters.AddWithValue("@KalkisZamani", dr["KalkisZamani"].ToString());
                        excelCommand.Parameters.AddWithValue("@BiletTutari", Convert.ToDecimal(dr["BiletTutari"]));
                        excelCommand.Parameters.AddWithValue("@SatisiYapilanBiletSayisi", Convert.ToInt32(dr["SatisiYapilanBiletSayisi"]));
                        excelCommand.ExecuteNonQuery();
                    }
                    excelConnection.Close();
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // toplam kaç kayıt olacak	 
            int toplamKayit = ((DataTable)dgRaporSonuc.DataSource).Rows.Count;
            // hangi sayfa bitiş sayfamız olacak. Bir sayfada 35 kayıt bulunacak.
            bitis = (toplamKayit - (toplamKayit % 35)) / 35;

        }

        int mevcutSayfa, bitis;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Rapor Başlığını yaz 
            e.Graphics.DrawString("Tarih Bazlı Rapor [" + dtBaslangicZamani.Value.ToShortDateString() + " - " + dtBitisZamani.Value.ToShortDateString() + "]", new Font("Verdana", 10), Brushes.Red, 80, 10);
            // Başlıkları yaz 
            e.Graphics.DrawString("Kalkış Şehri", new Font("Verdana", 8), Brushes.Red, 110, 80);
            e.Graphics.DrawString("Varış Şehri", new Font("Verdana", 8), Brushes.Red, 200, 80);
            e.Graphics.DrawString("Kalkış Zamanı", new Font("Verdana", 8), Brushes.Red, 280, 80);
            e.Graphics.DrawString("Varış Zamanı", new Font("Verdana", 8), Brushes.Red, 400, 80);
            e.Graphics.DrawString("Bilet Tutarı", new Font("Verdana", 8), Brushes.Red, 510, 80);
            e.Graphics.DrawString("Yolcu Adedi", new Font("Verdana", 8), Brushes.Red, 605, 80);

            // Başlıklar altına gerekli çizgileri çiz
            e.Graphics.DrawLine(new Pen(Brushes.Red), 80, 95, 700, 95);

            // Gerekli kayıtları bas. Her sayfada 30 sefer listelenecek.
            DataTable dt = (DataTable)dgRaporSonuc.DataSource; int y = 130;

            // e.HasMorePages=True olduğunda hangi kayıttan itibaren yazdırmaya başlanacak
            int baslangicKayit = mevcutSayfa * 35;

            // mevcut sayfaya kaç adet kayıt yazdırılacak.
            int bitisKayit = (baslangicKayit + 35 > dt.Rows.Count) ? dt.Rows.Count : baslangicKayit + 35;
            for (int i = baslangicKayit; i < bitisKayit; i++)
            {

                e.Graphics.DrawString(dt.Rows[i]["KalkisSehri"].ToString(), new Font("Verdana", 8), Brushes.Black, 110, y);
                e.Graphics.DrawString(dt.Rows[i]["VarisSehri"].ToString(), new Font("Verdana", 8), Brushes.Black, 200, y);
                e.Graphics.DrawString(Convert.ToDateTime(dt.Rows[i]["KalkisZamani"]).ToShortTimeString(), new Font("Verdana", 8), Brushes.Black, 280, y);

                DateTime varisZaman = DateTime.Now;
                bool sonuc = DateTime.TryParse(dt.Rows[i]["VarisZamani"].ToString(), out varisZaman);
                if (sonuc)
                {
                    e.Graphics.DrawString(Convert.ToDateTime(dt.Rows[i]["VarisZamani"]).ToShortTimeString(), new Font("Verdana", 8), Brushes.Black, 400, y);
                }
                else
                {
                    e.Graphics.DrawString(dt.Rows[i]["VarisZamani"].ToString(), new Font("Verdana", 8), Brushes.Black, 400, y);
                }

                e.Graphics.DrawString(Convert.ToDecimal(dt.Rows[i]["BiletTutari"]) + "TL", new Font("Verdana", 8), Brushes.Black, 510, y);
                e.Graphics.DrawString(dt.Rows[i]["SatisiYapilanBiletSayisi"].ToString(), new Font("Verdana", 8), Brushes.Black, 620, y);
                y += 30;
            }
            mevcutSayfa++;

            // e.HasMorePages= true olduğunda bu metod bir daha çalışacak
            e.HasMorePages = mevcutSayfa <= bitis;
        }
    }
}

