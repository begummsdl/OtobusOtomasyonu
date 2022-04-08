using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.MasrafTipIslemleri
{
    public partial class MasrafTipDetayGor : Form
    {
        public string MasrafTipID { get; set; }
        public MasrafTipDetayGor(string MID)
        {
            InitializeComponent();
            MasrafTipID = MID;
        }

        private void MasrafTipDetayGor_Load(object sender, EventArgs e)
        {
            this.Top=150;
            this.Left=80;
            Face.MasrafTip.MasrafTipDetayGor(lsvMasrafDetay, MasrafTipID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
