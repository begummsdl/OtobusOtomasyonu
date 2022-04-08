using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.Raporlar
{
    public partial class FrmSeferBazliRapor : Form
    {
        public FrmSeferBazliRapor()
        {
            InitializeComponent();
        }

        private void FrmSeferBazliRapor_Load(object sender, EventArgs e)
        {
            /*
            cmbKalkis.DisplayMember = "SehirAdi"; 
            cmbKalkis.ValueMember = "SehirId";
            cmbKalkis.DataSource = Face.Sehir.SehirListesi();
            cmbVaris.DisplayMember = "SehirAdi"; 
            cmbVaris.ValueMember = "SehirId"; 
            cmbVaris.DataSource = Face.Sehir.SehirListesi();
            dgRaporSonuc.AutoGenerateColumns = false;
            */
            
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            dgRaporSonuc.DataSource = Face.Sefer.SehirBazliSeferRapor(Convert.ToInt32(cmbKalkis.SelectedValue), Convert.ToInt32(cmbVaris.SelectedValue));
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
                if (folderBrowserDialog1.ShowDialog() ==
                DialogResult.OK)
                {
                    OleDbConnection excelConnection = new OleDbConnection("Data Source =" + folderBrowserDialog1.SelectedPath + "\\SehirBazlıRapor.xlsx; Provider = Microsoft.Jet.OLEDB.4.0; Extended Properties = Excel 9.0;");
                    OleDbCommand excelCommand = new OleDbCommand("CREATE TABLE[Rapor]([Kalkış Zamanı] string, [Varış Zamanı] string, [Bilet Tutarı] double, [Yolcu Sayısı] int);", excelConnection);
                    excelConnection.Open(); try
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

                        excelCommand = new OleDbCommand("Insert Into[Rapor$]([Kalkış Zamanı],[Varış Zamanı],[Bilet Tutarı], [Yolcu Sayısı]) Values(@KalkisZamani, @VarisZamani, @BiletTutari,@ YolcuSayisi)", excelConnection);

                        excelCommand.Parameters.AddWithValue("@KalkisZamani", dr["KalkisZamani"].ToString());
                        excelCommand.Parameters.AddWithValue("@VarisZamani", dr["VarisZamani"].ToString());
                        excelCommand.Parameters.AddWithValue("@BiletTutari", Convert.ToDecimal(dr["BiletTutari"]));
                        excelCommand.Parameters.AddWithValue("@YolcuSayisi", Convert.ToInt32(dr["ToplamYolcu"]));
                        excelCommand.ExecuteNonQuery();
                    }
                    excelConnection.Close();
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int toplamKayit = ((DataTable)dgRaporSonuc.DataSource).Rows.Count;
            bitis = (toplamKayit - (toplamKayit % 35)) / 35;
        }
        int mevcutSayfa, bitis;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Rapor Başlığını yaz 
            e.Graphics.DrawString("Sefer Bazlı Rapor [" + cmbKalkis.Text + " - " +cmbVaris.Text + "]", new Font("Verdana", 10), Brushes.Red, 80, 10);

            // Başlıkları yaz 
            e.Graphics.DrawString("Kalkış Zamanı", new Font("Verdana", 8), Brushes.Red, 80, 80);
            e.Graphics.DrawString("Varış Zamanı", new Font("Verdana", 8), Brushes.Red, 230, 80);
            e.Graphics.DrawString("Bilet Tutarı", new Font("Verdana", 8), Brushes.Red, 370, 80);
            e.Graphics.DrawString("Yolcu Adedi", new Font("Verdana", 8), Brushes.Red, 470, 80);

            // Başlıklar altına gerekli çizgileri çiz
            e.Graphics.DrawLine(new Pen(Brushes.Red), 80, 95, 700, 95);

            // Gerekli kayıtları bas. Her sayfada 35 sefer listelenecek.

            DataTable dt = (DataTable)dgRaporSonuc.DataSource; int y = 130;
            int baslangicKayit = mevcutSayfa * 35;

            int bitisKayit = (baslangicKayit + 35 > dt.Rows.
            Count) ? dt.Rows.Count : baslangicKayit + 35;

            for (int i = baslangicKayit; i < bitisKayit; i++)
            {

                e.Graphics.DrawString(Convert.ToDateTime(dt.Rows[i]["KalkisZamani"]).ToShortTimeString(), new Font("Verdana", 8), Brushes.Black, 80, y);

                DateTime varisZaman = DateTime.Now; bool sonuc = DateTime.TryParse(dt.Rows[i]["VarisZamani"].ToString(), out varisZaman);
                if (sonuc)
                    e.Graphics.DrawString(Convert.ToDateTime(dt.Rows[i]["VarisZamani"]).ToShortTimeString(), new Font("Verdana", 8), Brushes.Black, 230, y);
                else
                    e.Graphics.DrawString(dt.Rows[i]["VarisZamani"].ToString(), new Font("Verdana", 8), Brushes.Black, 230, y);

                e.Graphics.DrawString(Convert.ToDecimal(dt.Rows[i]["BiletTutari"]) + " TL", new Font("Verdana", 8), Brushes.Black, 370, y);
                e.Graphics.DrawString(dt.Rows[i]["ToplamYolcu"].ToString(), new Font("Verdana", 8), Brushes.Black, 470, y);

                y += 30;
            }

            mevcutSayfa++;

            e.HasMorePages = mevcutSayfa <= bitis;

        }
    }
}

