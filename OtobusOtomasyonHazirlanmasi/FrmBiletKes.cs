using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi
{
    public partial class FrmBiletKes : Form
    {
        public string YolcuAd { get; set; }
        public FrmBiletKes(string YolAd)
        {
            InitializeComponent();
            YolcuAd = YolAd;
        }

        private void FrmBiletKes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.BiletCikis' table. You can move, or remove it, as needed.
            txtAra.Text = YolcuAd;
            // TODO: This line of code loads data into the 'DataSet1.BiletCikis' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DataSet1.BiletCikis' table. You can move, or remove it, as needed. 
            this.reportViewer1.RefreshReport();
          
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            label1.Text = "Hayırlı Yolculuklar Dileriz";
            this.BiletCikisTableAdapter.Fill(this.DataSet1.BiletCikis, txtAra.Text);

            this.reportViewer1.RefreshReport(); 

        }
    }
}
