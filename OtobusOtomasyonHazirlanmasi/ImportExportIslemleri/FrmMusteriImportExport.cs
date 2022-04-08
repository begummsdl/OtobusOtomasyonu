using ClosedXML.Excel;
using ExcelDataReader;
using Face;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.ImportExportIslemleri
{
    public partial class FrmMusteriImportExport : Form
    {
        public FrmMusteriImportExport()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<Entity.Musteri> musteriler = new List<Entity.Musteri>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Entity.Musteri musteri = new Entity.Musteri();
                    musteri.Ad = dt.Rows[i]["Ad"].ToString();
                    musteri.SoyAd = dt.Rows[i]["Soyad"].ToString();
                    musteri.Email = dt.Rows[i]["Email"].ToString();
                    musteri.Telefon = dt.Rows[i]["Telefon"].ToString();
                    musteri.Cinsiyet = Convert.ToBoolean(dt.Rows[i]["Cinsiyet"]);
                    musteri.DogumTarihi = Convert.ToDateTime(dt.Rows[i]["DogumTarihi"]);
                    musteri.SehirID = Convert.ToInt32(dt.Rows[i]["SehirID"]);
                    musteri.Adres = dt.Rows[i]["Adres"].ToString();
                    musteri.KartNumarasi = dt.Rows[i]["KartNumarasi"].ToString();
                    musteri.KartTeslimDurumu = Convert.ToBoolean(dt.Rows[i]["KartTeslimDurumu"]);
                    musteri.MevcutPara = Convert.ToDecimal(dt.Rows[i]["MevcutPara"]);
                    musteriler.Add(musteri);
                }
                musterilerBindingSource.DataSource = musteriler;
            }
        }

        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            cnn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("Insert into Musteriler(Ad,Soyad,Email,Telefon,Cinsiyet,DogumTarihi,SehirID,Adres,KartNumarasi,KartTeslimDurumu,MevcutPara)" +
                    "Values('"+dataGridView1.Rows[i].Cells[0].Value+"','" + dataGridView1.Rows[i].Cells[1].Value+"','" + dataGridView1.Rows[i].Cells[2].Value+"'," +
                    "'" + dataGridView1.Rows[i].Cells[3].Value+"','" + dataGridView1.Rows[i].Cells[4].Value+"','" + dataGridView1.Rows[i].Cells[5].Value+ "'," +
                    "'" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "'," +
                    "'" + dataGridView1.Rows[i].Cells[9].Value + "','" + dataGridView1.Rows[i].Cells[10].Value + "')", cnn);

                cmd.ExecuteNonQuery();   
            }
            cnn.Close();
            MessageBox.Show("import işlemi başarıyla gerçekleşti.");
        }

        private void FrmMusteriImportExport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusOtomasyonDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.otobusOtomasyonDataSet.Musteriler);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.otobusOtomasyonDataSet.Musteriler.CopyToDataTable(), "Musteriler");
                            workbook.SaveAs(sdf.FileName);
                        }
                        MessageBox.Show("Verilerin excel dosyasına export işlemi başarıyla gerçekleşti.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
